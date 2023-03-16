#ifndef NOVA_DATA_STRUCTURES
#define NOVA_DATA_STRUCTURES

#define NOVA_SOFTEN_AMOUNT .001
#define NOVA_SOFTEN_AMOUNT_x2 .002

struct NovaColor
{
    uint Packed;
};

fixed4 UnpackColor(NovaColor novaColor)
{
    uint packedColor = novaColor.Packed;
    return float4(packedColor & 255, (packedColor >> 8) & 255, (packedColor >> 16) & 255, (packedColor >> 24) & 255) * (1.0 / 255);
}

#if 1 //////////////////////// UIBlock2D ///////////////////////////////////
    struct SubQuadVert
    {
        float2 Pos;
        uint BlockDataIndex;
        float EdgeSoftenMask;

        float2 UVZoom;
        float2 CenterUV;
    };

    struct NovaQuadVert
    {
        float3 Pos : POSITION;
        float3 Normal : NORMAL;
    };

    struct UIBlock2DData
    {
        float2 QuadSize;
        float2 GradientCenter;

        float2 GradientSizeReciprocal;
        float2 GradientRotationSinCos;

        float2 ShadowOffset;
        NovaColor PrimaryColor;
        NovaColor GradientColor;

        NovaColor ShadowColor;
        float CornerRadius;
        float ShadowWidth;
        float ShadowBlur;

        uint TransformIndex;
        uint TexturePackSlice;
        NovaColor BorderColor;
        float BorderWidth;

        float2 RadialFillCenter;
        float RadialFillRotation;
        float RadialFillAngle;
    };

    struct BorderData
    {
        float2 OuterClipCenterLocation;
        float2 InnerClipCenterLocation;
        
        NovaColor Color;
        float InnerRadius;
        float OuterRadius;
        uint TransformIndex;
    };

    struct PerInstanceDropShadowShaderData
    {
        float2 Offset;
        float2 HalfBlockQuadSize;

        NovaColor Color;
        float Width;
        float Blur;
        float BlockClipRadius;

        uint TransformIndex;
        float EdgeSoftenMask;
        float2 RadialFillCenter;
        
        float RadialFillRotation;
        float RadialFillAngle;
        float2 _padding;
    };

    struct PerQuadDropShadowShaderData
    {
        float2 PositionInNode;
        float2 QuadSize;
    };
#endif

#if 1 //////////////////////// UIBlock3D ///////////////////////////////////
    struct UIBlock3DVert
    {
        float3 Pos : POSITION;
        float3 Normal : NORMAL;
        float3 CornerOffsetDir : TEXCOORD0;
        float3 EdgeOffsetDir : TEXCOORD1;
    };

    struct UIBlock3DData
    {
        float3 Size;
        float CornerRadius;

        float EdgeRadius;
        NovaColor Color;
        uint TransformIndex;
        float _padding;
    };
#endif

#if 1 //////////////////////// TextBlock ///////////////////////////////////
    struct PerVertTextData
    {
        float3 Position;
        uint TransformIndex;

        float2 Texcoord0;
        float2 Texcoord1;

        NovaColor Color;
        float ScaleMultiplier;
        float2 _padding;
    };
#endif

#if 1 //////////////////////// Lighting ///////////////////////////////////
    struct BlinnPhongData
    {
        float Specular;
        float Gloss;
        float2 _padding;
    };

    struct StandardData
    {
        float Smoothness;
        float Metallic;
        float2 _padding;
    };

    struct StandardSpecularData
    {
        NovaColor SpecularColor;
        float Smoothness;
        float2 _padding;
    };

    struct TransformAndLighting
    {
        float4x4 RootFromBlock;
        #if defined(NOVA_BLINNPHONG_LIGHTING)
            BlinnPhongData Lighting;
        #elif defined(NOVA_STANDARD_LIGHTING)
            StandardData Lighting;
        #elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
            StandardSpecularData Lighting;
        #else
            float4 _padding;
        #endif
    };
#endif

#endif