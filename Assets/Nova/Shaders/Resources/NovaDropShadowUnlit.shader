Shader "Hidden/Nova/NovaDropShadowUnlit"
{
    Properties
    {
        [HideInInspector]
        _SrcBlend ("SrcBlend", Float) = 1
        [HideInInspector]
        _DstBlend ("DstBlend", Float) = 0
        [HideInInspector]
        _CullMode ("CullMode", Float) = 2
        [HideInInspector]
        _ZTest ("ZTest", Float) = 4
    }

    SubShader
    {
        Pass
        {
            Tags { "Queue" = "Transparent" "RenderType" = "Transparent" "DisableBatching" = "True" }

            ZWrite Off
            Blend [_SrcBlend] [_DstBlend]
            Lighting Off
            Tags { "DisableBatching" = "True" }
            Cull [_CullMode]
            ZTest [_ZTest]

            CGPROGRAM

            #define PROCEDURAL_INSTANCING_ON
            #pragma instancing_options procedural:setup
            #pragma instancing_options assumeuniformscaling
            #pragma instancing_options nolightmap
            #pragma instancing_options nolodfade
            #pragma skip_variants FOG_LINEAR FOG_EXP FOG_EXP2
            // 

            #pragma multi_compile_local __ NOVA_COLOR_MODIFIER NOVA_CLIP_RECT NOVA_CLIP_MASK
            #pragma multi_compile_local __ NOVA_RADIAL_FILL
            
            #pragma vertex NovaVert
            #pragma fragment NovaFrag
            #pragma target 4.5

            #include "../DropShadow.cginc"

            NOVA_DUMMY_INSTANCE_SETUP

            ENDCG
        }
    }
}
