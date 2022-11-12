Shader "Hidden/Nova/NovaUIBlock3DStandardOpaque"
{
    Properties
    {
        [HideInInspector]
        _ZWrite ("ZWrite", Float) = 1
        [HideInInspector]
        _SrcBlend ("SrcBlend", Float) = 1
        [HideInInspector]
        _DstBlend ("DstBlend", Float) = 0
        [HideInInspector]
        _CullMode ("CullMode", Float) = 2
        [HideInInspector]
        _AdditiveLightingSrcBlend ("AdditiveLightingSrcBlend", Float) = 1
        [HideInInspector]
        _AdditiveLightingDstBlend ("AdditiveLightingDstBlend", Float) = 1
        [HideInInspector]
        _CullMode ("CullMode", Float) = 2
        [HideInInspector]
        _ClipMaskTex ("ClipMaskTex", 2D) = "white" { }
        [HideInInspector]
        _ZTest ("ZTest", Float) = 4

    }

    CGINCLUDE

    ENDCG

    SubShader
    {
        
        // ---- forward rendering base pass:
        Pass
        {
            Name "FORWARD"
            Tags { "LightMode" = "ForwardBase" "DisableBatching" = "True" }
            ZWrite [_ZWrite]
            Blend [_SrcBlend] [_DstBlend]
            Cull [_CullMode]
            ZTest [_ZTest]

            CGPROGRAM
			// 

            // compile directives
            #pragma vertex NovaVert
            #pragma fragment NovaFrag
            #pragma target 4.5
            #define PROCEDURAL_INSTANCING_ON
            #pragma instancing_options procedural:setup
            #pragma instancing_options assumeuniformscaling
            #pragma instancing_options nolightmap
            #pragma instancing_options nolodfade
            
            #pragma multi_compile_fwdbase

            #pragma skip_variants LIGHTMAP_ON DIRLIGHTMAP_COMBINED DYNAMICLIGHTMAP_ON LIGHTMAP_SHADOW_MIXING SHADOWS_SHADOWMASK
            #pragma skip_variants FOG_LINEAR FOG_EXP FOG_EXP2

            #include "HLSLSupport.cginc"
            
            #define UNITY_INSTANCED_SH
            #define UNITY_INSTANCED_LIGHTMAPSTS
            #include "UnityShaderVariables.cginc"
            #include "UnityShaderUtilities.cginc"
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "AutoLight.cginc"

            #define INTERNAL_DATA
            #define WorldReflectionVector(data, normal) data.worldRefl
            #define WorldNormalVector(data, normal) normal

            #define NOVA_FORWARD_BASE_PASS

            #define NOVA_STANDARD_LIGHTING
            
            #pragma multi_compile_local __ NOVA_COLOR_MODIFIER NOVA_CLIP_RECT NOVA_CLIP_MASK            #include "../UIBlock3D.cginc"


            NOVA_DUMMY_INSTANCE_SETUP

            ENDCG

        }

        // ---- forward rendering additive lights pass:
        Pass
        {
            Name "FORWARD"
            Tags { "LightMode" = "ForwardAdd" "DisableBatching" = "True" }
            ZWrite Off
            Blend [_AdditiveLightingSrcBlend] [_AdditiveLightingDstBlend]
            ZTest [_ZTest]
            
            CGPROGRAM

			// 
            // compile directives
            #pragma vertex NovaVert
            #pragma fragment NovaFrag
            #pragma target 4.5
            #define PROCEDURAL_INSTANCING_ON
            #pragma instancing_options procedural:setup
            #pragma skip_variants SHADOWS_SHADOWMASK
            #pragma skip_variants FOG_LINEAR FOG_EXP FOG_EXP2

            #define NOVA_FORWARD_ADD_PASS

            #pragma multi_compile_fwdadd_fullshadows
            
            #include "HLSLSupport.cginc"
            
            #define UNITY_INSTANCED_SH
            #define UNITY_INSTANCED_LIGHTMAPSTS
            #include "UnityShaderVariables.cginc"
            #include "UnityShaderUtilities.cginc"
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "AutoLight.cginc"

            #define INTERNAL_DATA
            #define WorldReflectionVector(data, normal) data.worldRefl
            #define WorldNormalVector(data, normal) normal

            #define NOVA_STANDARD_LIGHTING
            
            #pragma multi_compile_local __ NOVA_COLOR_MODIFIER NOVA_CLIP_RECT NOVA_CLIP_MASK            #include "../UIBlock3D.cginc"

            
            NOVA_DUMMY_INSTANCE_SETUP

            ENDCG

        }

        // ---- shadow caster pass:
        Pass
        {
            Name "ShadowCaster"
            Tags { "LightMode" = "ShadowCaster" "DisableBatching" = "True" }
            ZWrite On
            ZTest LEqual

            CGPROGRAM

			// 
            #pragma vertex NovaVert
            #pragma fragment NovaFrag
            #pragma target 4.5
            #define PROCEDURAL_INSTANCING_ON
            #pragma instancing_options procedural:setup
            #pragma skip_variants FOG_LINEAR FOG_EXP FOG_EXP2
            #pragma multi_compile_shadowcaster
            #include "HLSLSupport.cginc"
            
            #define UNITY_INSTANCED_SH
            #define UNITY_INSTANCED_LIGHTMAPSTS
            #include "UnityShaderVariables.cginc"
            #include "UnityShaderUtilities.cginc"

            #define NOVA_SHADOW_CAST_PASS
            
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #define INTERNAL_DATA
            #define WorldReflectionVector(data, normal) data.worldRefl
            #define WorldNormalVector(data, normal) normal

            #define NOVA_STANDARD_LIGHTING
            
            #pragma multi_compile_local __ NOVA_COLOR_MODIFIER NOVA_CLIP_RECT NOVA_CLIP_MASK            #include "../UIBlock3D.cginc"


            NOVA_DUMMY_INSTANCE_SETUP

            ENDCG

        }
    }
    Fallback "Diffuse"
}
