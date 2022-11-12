#ifndef NOVA_UIBLOCK_3D
#define NOVA_UIBLOCK_3D

#include "Nova.cginc"
#include "Generated/UIBlock3D.g.cginc"

StructuredBuffer<UIBlock3DData> _NovaData;

v2f NovaVert(UIBlock3DVert v, uint instanceID : SV_InstanceID)
{
    NovaVertInit(instanceID, v2f, o);

    uint index = _NovaDataIndices[InstanceIDToDataIndex(instanceID)];
    UIBlock3DData shaderData = _NovaData[index];

    float3 vertNodePos = v.Pos * shaderData.Size + v.CornerOffsetDir * shaderData.CornerRadius + v.EdgeOffsetDir * shaderData.EdgeRadius;

    TransformAndLighting transformAndLighting = _NovaTransformsAndLighting[shaderData.TransformIndex];
    float3 rootSpace = mul(transformAndLighting.RootFromBlock, float4(vertNodePos, 1)).xyz;
    float3 worldPos = NovaRootToWorldPos(rootSpace);
    o.pos = UnityWorldToClipPos(worldPos);

    #if defined(NOVA_CLIPPING)
        float2 nClipRectPos = NClipRectPosFromWorld(worldPos);
        SetNClipRectPos(o, nClipRectPos);
    #endif

    NovaColorToV2F(Color, o, shaderData.Color);

    #if defined(NOVA_LIT)
        NovaSetLitV2FParams(o, transformAndLighting);
        SetWorldPos(o, worldPos);
        float3 rootNormal = NovaRootFromBlockNormal(transformAndLighting.RootFromBlock, v.Normal);
        float3 worldNormal = UnityObjectToWorldNormal(rootNormal);
        SetWorldNormal(o, worldNormal);

        NovaInitInstance(appdata_full, appdata);
        appdata.vertex = float4(rootSpace, 1);
        appdata.normal = rootNormal;

        NovaDoLitVert(o, worldPos, worldNormal, appdata);
    #endif


    return o;
}

fixed4 NovaFrag(v2f i) : SV_Target
{
    NovaFragInit(i);

    fixed4 color = GetColor(i);

    #if defined(NOVA_CLIPPING)
        half distanceOutsideBounds = DistanceOutsideCircleEdge(GetNClipRectPos(i), ClipRectNCornerOrigin, ClipRectNRadius);
        half softenInverse = GetSoftenWidthInverse(GetNClipRectPos(i));
        half weight = GetClipWeight10(distanceOutsideBounds, softenInverse);

        // NOTE: We don't soften here, just clip
        clip(weight - 1.0);
    #endif
    
    #if defined(NOVA_CLIPPING)
        color = ApplyClipColorModification(color, GetNClipRectPos(i));
    #elif defined(NOVA_COLOR_MODIFIER)
        color = ApplyClipColorModification(color);
    #endif

    #if defined(NOVA_LIT)
        color = NovaDoLightingCalculations(i, color);
    #endif

    return color;
}

#endif