#ifndef NOVA_TEXT_STRUCTURES
#define NOVA_TEXT_STRUCTURES

#include "../NovaPreV2F.cginc"

////////////////// BEGIN GENERATED //////////////////
#define GetFaceColor(val) val.FaceColor
#define SetFaceColor(val, toSet) val.FaceColor = toSet
#if defined(USES_BIAS_OUT)
	#if defined(OUTLINE_ON)
		#define GetScaleParam(val) val.Packed0.x
		#define SetScaleParam(val, toSet) val.Packed0.x = toSet
		#define GetBiasParam(val) val.Packed0.y
		#define SetBiasParam(val, toSet) val.Packed0.y = toSet
		#define GetBiasOutParam(val) val.Packed0.z
		#define SetBiasOutParam(val, toSet) val.Packed0.z = toSet
		#define GetBiasInParam(val) val.Packed0.w
		#define SetBiasInParam(val, toSet) val.Packed0.w = toSet
		#define GetOutlineColor(val) val.OutlineColor
		#define SetOutlineColor(val, toSet) val.OutlineColor = toSet
		#if defined(UNDERLAY_INNER)
			#define GetTextureUV(val) val.Packed1.xy
			#define SetTextureUV(val, toSet) val.Packed1.xy = toSet
			#define GetUnderlayUV(val) val.Packed1.zw
			#define SetUnderlayUV(val, toSet) val.Packed1.zw = toSet
			#if defined(UNDERLAY_ON)
				#define GetUnderlayScale(val) val.Packed2.x
				#define SetUnderlayScale(val, toSet) val.Packed2.x = toSet
				#define GetUnderlayBias(val) val.Packed2.y
				#define SetUnderlayBias(val, toSet) val.Packed2.y = toSet
				#define GetUnderlayScale(val) val.Packed2.z
				#define SetUnderlayScale(val, toSet) val.Packed2.z = toSet
				#define GetUnderlayBias(val) val.Packed2.w
				#define SetUnderlayBias(val, toSet) val.Packed2.w = toSet
				#if defined(NOVA_CLIPPING)
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayUV(val) val.Packed4.xy
							#define SetUnderlayUV(val, toSet) val.Packed4.xy = toSet
							#define GetNClipRectPos(val) val.Packed5.xy
							#define SetNClipRectPos(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define GetWorldNormal(val) half3(val.Packed3.w, val.Packed4.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed3.w = toSet.x; \
								val.Packed4.zw = toSet.yz;
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSpecular(val) val.Packed3.z
							#define SetSpecular(val, toSet) val.Packed3.z = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed6.x
							#define SetUnderlayAlpha(val, toSet) val.Packed6.x = toSet
							#define GetUnderlayAlpha(val) val.Packed6.y
							#define SetUnderlayAlpha(val, toSet) val.Packed6.y = toSet
							#define GetWorldNormal(val) half3(val.Packed4.w, val.Packed5.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed4.w = toSet.x; \
								val.Packed5.zw = toSet.yz;
							#define POST_NOVA_0 9
							#define POST_NOVA_1 10
							#define POST_NOVA_2 11
							#define POST_NOVA_3 12
							#define POST_NOVA_4 13
							#define POST_NOVA_5 14
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSmoothness(val) val.Packed3.z
							#define SetSmoothness(val, toSet) val.Packed3.z = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed6.x
							#define SetUnderlayAlpha(val, toSet) val.Packed6.x = toSet
							#define GetUnderlayAlpha(val) val.Packed6.y
							#define SetUnderlayAlpha(val, toSet) val.Packed6.y = toSet
							#define GetWorldNormal(val) half3(val.Packed4.w, val.Packed5.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed4.w = toSet.x; \
								val.Packed5.zw = toSet.yz;
							#define POST_NOVA_0 9
							#define POST_NOVA_1 10
							#define POST_NOVA_2 11
							#define POST_NOVA_3 12
							#define POST_NOVA_4 13
							#define POST_NOVA_5 14
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetSpecularColor(val) val.Packed4.xyz
							#define SetSpecularColor(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetWorldPos(val) val.Packed5.xyz
							#define SetWorldPos(val, toSet) val.Packed5.xyz = toSet
							#define GetUnderlayUV(val) val.Packed6.xy
							#define SetUnderlayUV(val, toSet) val.Packed6.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed6.w
							#define SetUnderlayAlpha(val, toSet) val.Packed6.w = toSet
							#define GetNClipRectPos(val) half2(val.Packed5.w, val.Packed6.z)
							#define SetNClipRectPos(val, toSet) \
								val.Packed5.w = toSet.x; \
								val.Packed6.z = toSet.y;
							#define POST_NOVA_0 9
							#define POST_NOVA_1 10
							#define POST_NOVA_2 11
							#define POST_NOVA_3 12
							#define POST_NOVA_4 13
							#define POST_NOVA_5 14
						#endif
					#else
						#define GetUnderlayUV(val) val.Packed3.xy
						#define SetUnderlayUV(val, toSet) val.Packed3.xy = toSet
						#define GetNClipRectPos(val) val.Packed3.zw
						#define SetNClipRectPos(val, toSet) val.Packed3.zw = toSet
						#define GetUnderlayAlpha(val) val.Packed4.x
						#define SetUnderlayAlpha(val, toSet) val.Packed4.x = toSet
						#define GetUnderlayAlpha(val) val.Packed4.y
						#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayUV(val) val.Packed4.xy
							#define SetUnderlayUV(val, toSet) val.Packed4.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.x
							#define SetUnderlayAlpha(val, toSet) val.Packed5.x = toSet
							#define GetUnderlayAlpha(val) val.Packed5.y
							#define SetUnderlayAlpha(val, toSet) val.Packed5.y = toSet
							#define GetWorldNormal(val) half3(val.Packed3.w, val.Packed4.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed3.w = toSet.x; \
								val.Packed4.zw = toSet.yz;
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSpecular(val) val.Packed3.w
							#define SetSpecular(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetGloss(val) val.Packed4.w
							#define SetGloss(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetMetallic(val) val.Packed4.w
							#define SetMetallic(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetSpecularColor(val) val.Packed4.xyz
							#define SetSpecularColor(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetWorldPos(val) val.Packed5.xyz
							#define SetWorldPos(val, toSet) val.Packed5.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayUV(val) val.UnderlayUV
							#define SetUnderlayUV(val, toSet) val.UnderlayUV = toSet
							#define POST_NOVA_0 9
							#define POST_NOVA_1 10
							#define POST_NOVA_2 11
							#define POST_NOVA_3 12
							#define POST_NOVA_4 13
							#define POST_NOVA_5 14
						#endif
					#else
						#define GetUnderlayUV(val) val.Packed3.xy
						#define SetUnderlayUV(val, toSet) val.Packed3.xy = toSet
						#define GetUnderlayAlpha(val) val.Packed3.z
						#define SetUnderlayAlpha(val, toSet) val.Packed3.z = toSet
						#define GetUnderlayAlpha(val) val.Packed3.w
						#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
					#endif
				#endif
			#else
				#if defined(NOVA_CLIPPING)
					#define GetUnderlayScale(val) val.Packed2.x
					#define SetUnderlayScale(val, toSet) val.Packed2.x = toSet
					#define GetUnderlayBias(val) val.Packed2.y
					#define SetUnderlayBias(val, toSet) val.Packed2.y = toSet
					#define GetNClipRectPos(val) val.Packed2.zw
					#define SetNClipRectPos(val, toSet) val.Packed2.zw = toSet
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldNormal(val) val.WorldNormal
							#define SetWorldNormal(val, toSet) val.WorldNormal = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSpecular(val) val.Packed3.w
							#define SetSpecular(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetGloss(val) val.Packed4.w
							#define SetGloss(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetMetallic(val) val.Packed4.w
							#define SetMetallic(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayAlpha(val) val.Packed4.x
							#define SetUnderlayAlpha(val, toSet) val.Packed4.x = toSet
							#define GetSpecularColor(val) val.Packed4.yzw
							#define SetSpecularColor(val, toSet) val.Packed4.yzw = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetUnderlayAlpha(val) val.UnderlayAlpha
						#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayScale(val) val.Packed2.w
						#define SetUnderlayScale(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetSpecular(val) val.Packed4.x
							#define SetSpecular(val, toSet) val.Packed4.x = toSet
							#define GetGloss(val) val.Packed4.y
							#define SetGloss(val, toSet) val.Packed4.y = toSet
							#define GetUnderlayAlpha(val) val.Packed4.z
							#define SetUnderlayAlpha(val, toSet) val.Packed4.z = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetSmoothness(val) val.Packed4.x
							#define SetSmoothness(val, toSet) val.Packed4.x = toSet
							#define GetMetallic(val) val.Packed4.y
							#define SetMetallic(val, toSet) val.Packed4.y = toSet
							#define GetUnderlayAlpha(val) val.Packed4.z
							#define SetUnderlayAlpha(val, toSet) val.Packed4.z = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayBias(val) val.Packed4.w
							#define SetUnderlayBias(val, toSet) val.Packed4.w = toSet
							#define GetSmoothness(val) val.Smoothness
							#define SetSmoothness(val, toSet) val.Smoothness = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetUnderlayScale(val) val.Packed2.x
						#define SetUnderlayScale(val, toSet) val.Packed2.x = toSet
						#define GetUnderlayBias(val) val.Packed2.y
						#define SetUnderlayBias(val, toSet) val.Packed2.y = toSet
						#define GetUnderlayAlpha(val) val.Packed2.z
						#define SetUnderlayAlpha(val, toSet) val.Packed2.z = toSet
					#endif
				#endif
			#endif
		#else
			#if defined(UNDERLAY_ON)
				#define GetTextureUV(val) val.Packed1.xy
				#define SetTextureUV(val, toSet) val.Packed1.xy = toSet
				#define GetUnderlayUV(val) val.Packed1.zw
				#define SetUnderlayUV(val, toSet) val.Packed1.zw = toSet
				#if defined(NOVA_CLIPPING)
					#define GetUnderlayScale(val) val.Packed2.x
					#define SetUnderlayScale(val, toSet) val.Packed2.x = toSet
					#define GetUnderlayBias(val) val.Packed2.y
					#define SetUnderlayBias(val, toSet) val.Packed2.y = toSet
					#define GetNClipRectPos(val) val.Packed2.zw
					#define SetNClipRectPos(val, toSet) val.Packed2.zw = toSet
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldNormal(val) val.WorldNormal
							#define SetWorldNormal(val, toSet) val.WorldNormal = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSpecular(val) val.Packed3.w
							#define SetSpecular(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetGloss(val) val.Packed4.w
							#define SetGloss(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetMetallic(val) val.Packed4.w
							#define SetMetallic(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayAlpha(val) val.Packed4.x
							#define SetUnderlayAlpha(val, toSet) val.Packed4.x = toSet
							#define GetSpecularColor(val) val.Packed4.yzw
							#define SetSpecularColor(val, toSet) val.Packed4.yzw = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetUnderlayAlpha(val) val.UnderlayAlpha
						#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayScale(val) val.Packed2.w
						#define SetUnderlayScale(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetSpecular(val) val.Packed4.x
							#define SetSpecular(val, toSet) val.Packed4.x = toSet
							#define GetGloss(val) val.Packed4.y
							#define SetGloss(val, toSet) val.Packed4.y = toSet
							#define GetUnderlayAlpha(val) val.Packed4.z
							#define SetUnderlayAlpha(val, toSet) val.Packed4.z = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetSmoothness(val) val.Packed4.x
							#define SetSmoothness(val, toSet) val.Packed4.x = toSet
							#define GetMetallic(val) val.Packed4.y
							#define SetMetallic(val, toSet) val.Packed4.y = toSet
							#define GetUnderlayAlpha(val) val.Packed4.z
							#define SetUnderlayAlpha(val, toSet) val.Packed4.z = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayBias(val) val.Packed4.w
							#define SetUnderlayBias(val, toSet) val.Packed4.w = toSet
							#define GetSmoothness(val) val.Smoothness
							#define SetSmoothness(val, toSet) val.Smoothness = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetUnderlayScale(val) val.Packed2.x
						#define SetUnderlayScale(val, toSet) val.Packed2.x = toSet
						#define GetUnderlayBias(val) val.Packed2.y
						#define SetUnderlayBias(val, toSet) val.Packed2.y = toSet
						#define GetUnderlayAlpha(val) val.Packed2.z
						#define SetUnderlayAlpha(val, toSet) val.Packed2.z = toSet
					#endif
				#endif
			#else
				#if defined(NOVA_CLIPPING)
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define GetWorldNormal(val) half3(val.Packed1.w, val.Packed2.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed1.w = toSet.x; \
								val.Packed2.zw = toSet.yz;
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetNClipRectPos(val) val.Packed1.xy
							#define SetNClipRectPos(val, toSet) val.Packed1.xy = toSet
							#define GetSpecular(val) val.Packed1.z
							#define SetSpecular(val, toSet) val.Packed1.z = toSet
							#define GetGloss(val) val.Packed1.w
							#define SetGloss(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetWorldNormal(val) half3(val.Packed2.w, val.Packed3.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed2.w = toSet.x; \
								val.Packed3.zw = toSet.yz;
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetNClipRectPos(val) val.Packed1.xy
							#define SetNClipRectPos(val, toSet) val.Packed1.xy = toSet
							#define GetSmoothness(val) val.Packed1.z
							#define SetSmoothness(val, toSet) val.Packed1.z = toSet
							#define GetMetallic(val) val.Packed1.w
							#define SetMetallic(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetWorldNormal(val) half3(val.Packed2.w, val.Packed3.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed2.w = toSet.x; \
								val.Packed3.zw = toSet.yz;
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed1.xyz
							#define SetWorldNormal(val, toSet) val.Packed1.xyz = toSet
							#define GetSmoothness(val) val.Packed1.w
							#define SetSmoothness(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetSpecularColor(val) val.SpecularColor
							#define SetSpecularColor(val, toSet) val.SpecularColor = toSet
							#define GetNClipRectPos(val) half2(val.Packed2.w, val.Packed3.z)
							#define SetNClipRectPos(val, toSet) \
								val.Packed2.w = toSet.x; \
								val.Packed3.z = toSet.y;
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetTextureUV(val) val.Packed1.xy
						#define SetTextureUV(val, toSet) val.Packed1.xy = toSet
						#define GetNClipRectPos(val) val.Packed1.zw
						#define SetNClipRectPos(val, toSet) val.Packed1.zw = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetWorldNormal(val) half3(val.Packed1.w, val.Packed2.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed1.w = toSet.x; \
								val.Packed2.zw = toSet.yz;
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldNormal(val) val.Packed1.xyz
							#define SetWorldNormal(val, toSet) val.Packed1.xyz = toSet
							#define GetSpecular(val) val.Packed1.w
							#define SetSpecular(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetGloss(val) val.Packed2.w
							#define SetGloss(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldNormal(val) val.Packed1.xyz
							#define SetWorldNormal(val, toSet) val.Packed1.xyz = toSet
							#define GetSmoothness(val) val.Packed1.w
							#define SetSmoothness(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetMetallic(val) val.Packed2.w
							#define SetMetallic(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed1.xyz
							#define SetWorldNormal(val, toSet) val.Packed1.xyz = toSet
							#define GetSmoothness(val) val.Packed1.w
							#define SetSmoothness(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetSpecularColor(val) fixed3(val.Packed2.w, val.Packed3.zw)
							#define SetSpecularColor(val, toSet) \
								val.Packed2.w = toSet.x; \
								val.Packed3.zw = toSet.yz;
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#endif
					#else
						#define GetTextureUV(val) val.TextureUV
						#define SetTextureUV(val, toSet) val.TextureUV = toSet
					#endif
				#endif
			#endif
		#endif
	#else
		#if defined(UNDERLAY_INNER)
			#define GetTextureUV(val) val.Packed0.xy
			#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
			#define GetUnderlayUV(val) val.Packed0.zw
			#define SetUnderlayUV(val, toSet) val.Packed0.zw = toSet
			#define GetScaleParam(val) val.Packed1.x
			#define SetScaleParam(val, toSet) val.Packed1.x = toSet
			#define GetBiasParam(val) val.Packed1.y
			#define SetBiasParam(val, toSet) val.Packed1.y = toSet
			#define GetBiasOutParam(val) val.Packed1.z
			#define SetBiasOutParam(val, toSet) val.Packed1.z = toSet
			#define GetUnderlayScale(val) val.Packed1.w
			#define SetUnderlayScale(val, toSet) val.Packed1.w = toSet
			#if defined(UNDERLAY_ON)
				#if defined(NOVA_CLIPPING)
					#define GetNClipRectPos(val) val.Packed2.xy
					#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
					#define GetUnderlayBias(val) val.Packed2.z
					#define SetUnderlayBias(val, toSet) val.Packed2.z = toSet
					#define GetUnderlayScale(val) val.Packed2.w
					#define SetUnderlayScale(val, toSet) val.Packed2.w = toSet
					#if defined(NOVA_LIT)
						#define GetUnderlayBias(val) val.Packed3.x
						#define SetUnderlayBias(val, toSet) val.Packed3.x = toSet
						#define GetWorldNormal(val) val.Packed3.yzw
						#define SetWorldNormal(val, toSet) val.Packed3.yzw = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSpecular(val) val.Packed4.w
							#define SetSpecular(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetGloss(val) val.Packed5.z
							#define SetGloss(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetMetallic(val) val.Packed5.z
							#define SetMetallic(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetSpecularColor(val) val.Packed4.xyz
							#define SetSpecularColor(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetWorldPos(val) val.Packed5.xyz
							#define SetWorldPos(val, toSet) val.Packed5.xyz = toSet
							#define GetSmoothness(val) val.Packed5.w
							#define SetSmoothness(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayUV(val) val.Packed6.xy
							#define SetUnderlayUV(val, toSet) val.Packed6.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed6.z
							#define SetUnderlayAlpha(val, toSet) val.Packed6.z = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetUnderlayUV(val) val.Packed3.xy
						#define SetUnderlayUV(val, toSet) val.Packed3.xy = toSet
						#define GetUnderlayBias(val) val.Packed3.z
						#define SetUnderlayBias(val, toSet) val.Packed3.z = toSet
						#define GetUnderlayAlpha(val) val.Packed3.w
						#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
						#define GetUnderlayAlpha(val) val.UnderlayAlpha
						#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayBias(val) val.Packed2.w
						#define SetUnderlayBias(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayUV(val) val.Packed4.xy
							#define SetUnderlayUV(val, toSet) val.Packed4.xy = toSet
							#define GetUnderlayScale(val) val.Packed4.z
							#define SetUnderlayScale(val, toSet) val.Packed4.z = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetUnderlayBias(val) val.Packed3.x
							#define SetUnderlayBias(val, toSet) val.Packed3.x = toSet
							#define GetUnderlayScale(val) val.Packed3.y
							#define SetUnderlayScale(val, toSet) val.Packed3.y = toSet
							#define GetSpecular(val) val.Packed3.z
							#define SetSpecular(val, toSet) val.Packed3.z = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetUnderlayBias(val) val.Packed3.x
							#define SetUnderlayBias(val, toSet) val.Packed3.x = toSet
							#define GetUnderlayScale(val) val.Packed3.y
							#define SetUnderlayScale(val, toSet) val.Packed3.y = toSet
							#define GetSmoothness(val) val.Packed3.z
							#define SetSmoothness(val, toSet) val.Packed3.z = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetSpecularColor(val) val.Packed3.xyz
							#define SetSpecularColor(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayBias(val) val.Packed4.w
							#define SetUnderlayBias(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayScale(val) val.Packed5.z
							#define SetUnderlayScale(val, toSet) val.Packed5.z = toSet
							#define GetSmoothness(val) val.Packed5.w
							#define SetSmoothness(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetUnderlayUV(val) val.Packed2.xy
						#define SetUnderlayUV(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayBias(val) val.Packed2.z
						#define SetUnderlayBias(val, toSet) val.Packed2.z = toSet
						#define GetUnderlayScale(val) val.Packed2.w
						#define SetUnderlayScale(val, toSet) val.Packed2.w = toSet
						#define GetUnderlayBias(val) val.Packed3.x
						#define SetUnderlayBias(val, toSet) val.Packed3.x = toSet
						#define GetUnderlayAlpha(val) val.Packed3.y
						#define SetUnderlayAlpha(val, toSet) val.Packed3.y = toSet
						#define GetUnderlayAlpha(val) val.Packed3.z
						#define SetUnderlayAlpha(val, toSet) val.Packed3.z = toSet
					#endif
				#endif
			#else
				#if defined(NOVA_CLIPPING)
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayBias(val) val.Packed2.w
						#define SetUnderlayBias(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSpecular(val) val.Packed3.z
							#define SetSpecular(val, toSet) val.Packed3.z = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSmoothness(val) val.Packed3.z
							#define SetSmoothness(val, toSet) val.Packed3.z = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetNClipRectPos(val) val.Packed2.xy
						#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayBias(val) val.Packed2.z
						#define SetUnderlayBias(val, toSet) val.Packed2.z = toSet
						#define GetUnderlayAlpha(val) val.Packed2.w
						#define SetUnderlayAlpha(val, toSet) val.Packed2.w = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetUnderlayBias(val) val.Packed2.x
						#define SetUnderlayBias(val, toSet) val.Packed2.x = toSet
						#define GetWorldNormal(val) val.Packed2.yzw
						#define SetWorldNormal(val, toSet) val.Packed2.yzw = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetSpecular(val) val.Packed3.w
							#define SetSpecular(val, toSet) val.Packed3.w = toSet
							#define GetGloss(val) val.Packed4.x
							#define SetGloss(val, toSet) val.Packed4.x = toSet
							#define GetUnderlayAlpha(val) val.Packed4.y
							#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetMetallic(val) val.Packed4.x
							#define SetMetallic(val, toSet) val.Packed4.x = toSet
							#define GetUnderlayAlpha(val) val.Packed4.y
							#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#endif
					#else
						#define GetUnderlayBias(val) val.Packed2.x
						#define SetUnderlayBias(val, toSet) val.Packed2.x = toSet
						#define GetUnderlayAlpha(val) val.Packed2.y
						#define SetUnderlayAlpha(val, toSet) val.Packed2.y = toSet
					#endif
				#endif
			#endif
		#else
			#if defined(UNDERLAY_ON)
				#define GetTextureUV(val) val.Packed0.xy
				#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
				#define GetUnderlayUV(val) val.Packed0.zw
				#define SetUnderlayUV(val, toSet) val.Packed0.zw = toSet
				#define GetScaleParam(val) val.Packed1.x
				#define SetScaleParam(val, toSet) val.Packed1.x = toSet
				#define GetBiasParam(val) val.Packed1.y
				#define SetBiasParam(val, toSet) val.Packed1.y = toSet
				#define GetBiasOutParam(val) val.Packed1.z
				#define SetBiasOutParam(val, toSet) val.Packed1.z = toSet
				#define GetUnderlayScale(val) val.Packed1.w
				#define SetUnderlayScale(val, toSet) val.Packed1.w = toSet
				#if defined(NOVA_CLIPPING)
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayBias(val) val.Packed2.w
						#define SetUnderlayBias(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSpecular(val) val.Packed3.z
							#define SetSpecular(val, toSet) val.Packed3.z = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSmoothness(val) val.Packed3.z
							#define SetSmoothness(val, toSet) val.Packed3.z = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetNClipRectPos(val) val.Packed2.xy
						#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayBias(val) val.Packed2.z
						#define SetUnderlayBias(val, toSet) val.Packed2.z = toSet
						#define GetUnderlayAlpha(val) val.Packed2.w
						#define SetUnderlayAlpha(val, toSet) val.Packed2.w = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetUnderlayBias(val) val.Packed2.x
						#define SetUnderlayBias(val, toSet) val.Packed2.x = toSet
						#define GetWorldNormal(val) val.Packed2.yzw
						#define SetWorldNormal(val, toSet) val.Packed2.yzw = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetSpecular(val) val.Packed3.w
							#define SetSpecular(val, toSet) val.Packed3.w = toSet
							#define GetGloss(val) val.Packed4.x
							#define SetGloss(val, toSet) val.Packed4.x = toSet
							#define GetUnderlayAlpha(val) val.Packed4.y
							#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetMetallic(val) val.Packed4.x
							#define SetMetallic(val, toSet) val.Packed4.x = toSet
							#define GetUnderlayAlpha(val) val.Packed4.y
							#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#endif
					#else
						#define GetUnderlayBias(val) val.Packed2.x
						#define SetUnderlayBias(val, toSet) val.Packed2.x = toSet
						#define GetUnderlayAlpha(val) val.Packed2.y
						#define SetUnderlayAlpha(val, toSet) val.Packed2.y = toSet
					#endif
				#endif
			#else
				#if defined(NOVA_CLIPPING)
					#define GetNClipRectPos(val) val.Packed0.xy
					#define SetNClipRectPos(val, toSet) val.Packed0.xy = toSet
					#define GetScaleParam(val) val.Packed0.z
					#define SetScaleParam(val, toSet) val.Packed0.z = toSet
					#define GetBiasParam(val) val.Packed0.w
					#define SetBiasParam(val, toSet) val.Packed0.w = toSet
					#if defined(NOVA_LIT)
						#define GetBiasOutParam(val) val.Packed1.x
						#define SetBiasOutParam(val, toSet) val.Packed1.x = toSet
						#define GetWorldNormal(val) val.Packed1.yzw
						#define SetWorldNormal(val, toSet) val.Packed1.yzw = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetSpecular(val) val.Packed2.w
							#define SetSpecular(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetGloss(val) val.Packed3.z
							#define SetGloss(val, toSet) val.Packed3.z = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetMetallic(val) val.Packed3.z
							#define SetMetallic(val, toSet) val.Packed3.z = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define GetSpecularColor(val) val.SpecularColor
							#define SetSpecularColor(val, toSet) val.SpecularColor = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#endif
					#else
						#define GetTextureUV(val) val.Packed1.xy
						#define SetTextureUV(val, toSet) val.Packed1.xy = toSet
						#define GetBiasOutParam(val) val.Packed1.z
						#define SetBiasOutParam(val, toSet) val.Packed1.z = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed0.xyz
						#define SetWorldNormal(val, toSet) val.Packed0.xyz = toSet
						#define GetScaleParam(val) val.Packed0.w
						#define SetScaleParam(val, toSet) val.Packed0.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetBiasOutParam(val) val.Packed1.w
							#define SetBiasOutParam(val, toSet) val.Packed1.w = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetBiasParam(val) val.Packed2.z
							#define SetBiasParam(val, toSet) val.Packed2.z = toSet
							#define POST_NOVA_0 4
							#define POST_NOVA_1 5
							#define POST_NOVA_2 6
							#define POST_NOVA_3 7
							#define POST_NOVA_4 8
							#define POST_NOVA_5 9
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetBiasOutParam(val) val.Packed1.x
							#define SetBiasOutParam(val, toSet) val.Packed1.x = toSet
							#define GetBiasParam(val) val.Packed1.y
							#define SetBiasParam(val, toSet) val.Packed1.y = toSet
							#define GetSpecular(val) val.Packed1.z
							#define SetSpecular(val, toSet) val.Packed1.z = toSet
							#define GetGloss(val) val.Packed1.w
							#define SetGloss(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetBiasOutParam(val) val.Packed1.x
							#define SetBiasOutParam(val, toSet) val.Packed1.x = toSet
							#define GetBiasParam(val) val.Packed1.y
							#define SetBiasParam(val, toSet) val.Packed1.y = toSet
							#define GetSmoothness(val) val.Packed1.z
							#define SetSmoothness(val, toSet) val.Packed1.z = toSet
							#define GetMetallic(val) val.Packed1.w
							#define SetMetallic(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetBiasOutParam(val) val.Packed1.w
							#define SetBiasOutParam(val, toSet) val.Packed1.w = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetBiasParam(val) val.Packed2.z
							#define SetBiasParam(val, toSet) val.Packed2.z = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetSpecularColor(val) val.SpecularColor
							#define SetSpecularColor(val, toSet) val.SpecularColor = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#endif
					#else
						#define GetTextureUV(val) val.Packed0.xy
						#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
						#define GetScaleParam(val) val.Packed0.z
						#define SetScaleParam(val, toSet) val.Packed0.z = toSet
						#define GetBiasParam(val) val.Packed0.w
						#define SetBiasParam(val, toSet) val.Packed0.w = toSet
						#define GetBiasOutParam(val) val.BiasOutParam
						#define SetBiasOutParam(val, toSet) val.BiasOutParam = toSet
					#endif
				#endif
			#endif
		#endif
	#endif
#else
	#if defined(OUTLINE_ON)
		#define GetOutlineColor(val) val.OutlineColor
		#define SetOutlineColor(val, toSet) val.OutlineColor = toSet
		#if defined(UNDERLAY_INNER)
			#define GetTextureUV(val) val.Packed0.xy
			#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
			#define GetUnderlayUV(val) val.Packed0.zw
			#define SetUnderlayUV(val, toSet) val.Packed0.zw = toSet
			#define GetScaleParam(val) val.Packed1.x
			#define SetScaleParam(val, toSet) val.Packed1.x = toSet
			#define GetBiasParam(val) val.Packed1.y
			#define SetBiasParam(val, toSet) val.Packed1.y = toSet
			#define GetBiasInParam(val) val.Packed1.z
			#define SetBiasInParam(val, toSet) val.Packed1.z = toSet
			#define GetUnderlayScale(val) val.Packed1.w
			#define SetUnderlayScale(val, toSet) val.Packed1.w = toSet
			#if defined(UNDERLAY_ON)
				#if defined(NOVA_CLIPPING)
					#define GetNClipRectPos(val) val.Packed2.xy
					#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
					#define GetUnderlayBias(val) val.Packed2.z
					#define SetUnderlayBias(val, toSet) val.Packed2.z = toSet
					#define GetUnderlayScale(val) val.Packed2.w
					#define SetUnderlayScale(val, toSet) val.Packed2.w = toSet
					#if defined(NOVA_LIT)
						#define GetUnderlayBias(val) val.Packed3.x
						#define SetUnderlayBias(val, toSet) val.Packed3.x = toSet
						#define GetWorldNormal(val) val.Packed3.yzw
						#define SetWorldNormal(val, toSet) val.Packed3.yzw = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSpecular(val) val.Packed4.w
							#define SetSpecular(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetGloss(val) val.Packed5.z
							#define SetGloss(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 9
							#define POST_NOVA_1 10
							#define POST_NOVA_2 11
							#define POST_NOVA_3 12
							#define POST_NOVA_4 13
							#define POST_NOVA_5 14
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetMetallic(val) val.Packed5.z
							#define SetMetallic(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 9
							#define POST_NOVA_1 10
							#define POST_NOVA_2 11
							#define POST_NOVA_3 12
							#define POST_NOVA_4 13
							#define POST_NOVA_5 14
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetSpecularColor(val) val.Packed4.xyz
							#define SetSpecularColor(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetWorldPos(val) val.Packed5.xyz
							#define SetWorldPos(val, toSet) val.Packed5.xyz = toSet
							#define GetSmoothness(val) val.Packed5.w
							#define SetSmoothness(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayUV(val) val.Packed6.xy
							#define SetUnderlayUV(val, toSet) val.Packed6.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed6.z
							#define SetUnderlayAlpha(val, toSet) val.Packed6.z = toSet
							#define POST_NOVA_0 9
							#define POST_NOVA_1 10
							#define POST_NOVA_2 11
							#define POST_NOVA_3 12
							#define POST_NOVA_4 13
							#define POST_NOVA_5 14
						#endif
					#else
						#define GetUnderlayUV(val) val.Packed3.xy
						#define SetUnderlayUV(val, toSet) val.Packed3.xy = toSet
						#define GetUnderlayBias(val) val.Packed3.z
						#define SetUnderlayBias(val, toSet) val.Packed3.z = toSet
						#define GetUnderlayAlpha(val) val.Packed3.w
						#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
						#define GetUnderlayAlpha(val) val.UnderlayAlpha
						#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayBias(val) val.Packed2.w
						#define SetUnderlayBias(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayUV(val) val.Packed4.xy
							#define SetUnderlayUV(val, toSet) val.Packed4.xy = toSet
							#define GetUnderlayScale(val) val.Packed4.z
							#define SetUnderlayScale(val, toSet) val.Packed4.z = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetUnderlayBias(val) val.Packed3.x
							#define SetUnderlayBias(val, toSet) val.Packed3.x = toSet
							#define GetUnderlayScale(val) val.Packed3.y
							#define SetUnderlayScale(val, toSet) val.Packed3.y = toSet
							#define GetSpecular(val) val.Packed3.z
							#define SetSpecular(val, toSet) val.Packed3.z = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetUnderlayBias(val) val.Packed3.x
							#define SetUnderlayBias(val, toSet) val.Packed3.x = toSet
							#define GetUnderlayScale(val) val.Packed3.y
							#define SetUnderlayScale(val, toSet) val.Packed3.y = toSet
							#define GetSmoothness(val) val.Packed3.z
							#define SetSmoothness(val, toSet) val.Packed3.z = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetSpecularColor(val) val.Packed3.xyz
							#define SetSpecularColor(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayBias(val) val.Packed4.w
							#define SetUnderlayBias(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayScale(val) val.Packed5.z
							#define SetUnderlayScale(val, toSet) val.Packed5.z = toSet
							#define GetSmoothness(val) val.Packed5.w
							#define SetSmoothness(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 9
							#define POST_NOVA_1 10
							#define POST_NOVA_2 11
							#define POST_NOVA_3 12
							#define POST_NOVA_4 13
							#define POST_NOVA_5 14
						#endif
					#else
						#define GetUnderlayUV(val) val.Packed2.xy
						#define SetUnderlayUV(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayBias(val) val.Packed2.z
						#define SetUnderlayBias(val, toSet) val.Packed2.z = toSet
						#define GetUnderlayScale(val) val.Packed2.w
						#define SetUnderlayScale(val, toSet) val.Packed2.w = toSet
						#define GetUnderlayBias(val) val.Packed3.x
						#define SetUnderlayBias(val, toSet) val.Packed3.x = toSet
						#define GetUnderlayAlpha(val) val.Packed3.y
						#define SetUnderlayAlpha(val, toSet) val.Packed3.y = toSet
						#define GetUnderlayAlpha(val) val.Packed3.z
						#define SetUnderlayAlpha(val, toSet) val.Packed3.z = toSet
					#endif
				#endif
			#else
				#if defined(NOVA_CLIPPING)
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayBias(val) val.Packed2.w
						#define SetUnderlayBias(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSpecular(val) val.Packed3.z
							#define SetSpecular(val, toSet) val.Packed3.z = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSmoothness(val) val.Packed3.z
							#define SetSmoothness(val, toSet) val.Packed3.z = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetNClipRectPos(val) val.Packed2.xy
						#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayBias(val) val.Packed2.z
						#define SetUnderlayBias(val, toSet) val.Packed2.z = toSet
						#define GetUnderlayAlpha(val) val.Packed2.w
						#define SetUnderlayAlpha(val, toSet) val.Packed2.w = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetUnderlayBias(val) val.Packed2.x
						#define SetUnderlayBias(val, toSet) val.Packed2.x = toSet
						#define GetWorldNormal(val) val.Packed2.yzw
						#define SetWorldNormal(val, toSet) val.Packed2.yzw = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetSpecular(val) val.Packed3.w
							#define SetSpecular(val, toSet) val.Packed3.w = toSet
							#define GetGloss(val) val.Packed4.x
							#define SetGloss(val, toSet) val.Packed4.x = toSet
							#define GetUnderlayAlpha(val) val.Packed4.y
							#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetMetallic(val) val.Packed4.x
							#define SetMetallic(val, toSet) val.Packed4.x = toSet
							#define GetUnderlayAlpha(val) val.Packed4.y
							#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetUnderlayBias(val) val.Packed2.x
						#define SetUnderlayBias(val, toSet) val.Packed2.x = toSet
						#define GetUnderlayAlpha(val) val.Packed2.y
						#define SetUnderlayAlpha(val, toSet) val.Packed2.y = toSet
					#endif
				#endif
			#endif
		#else
			#if defined(UNDERLAY_ON)
				#define GetTextureUV(val) val.Packed0.xy
				#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
				#define GetUnderlayUV(val) val.Packed0.zw
				#define SetUnderlayUV(val, toSet) val.Packed0.zw = toSet
				#define GetScaleParam(val) val.Packed1.x
				#define SetScaleParam(val, toSet) val.Packed1.x = toSet
				#define GetBiasParam(val) val.Packed1.y
				#define SetBiasParam(val, toSet) val.Packed1.y = toSet
				#define GetBiasInParam(val) val.Packed1.z
				#define SetBiasInParam(val, toSet) val.Packed1.z = toSet
				#define GetUnderlayScale(val) val.Packed1.w
				#define SetUnderlayScale(val, toSet) val.Packed1.w = toSet
				#if defined(NOVA_CLIPPING)
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayBias(val) val.Packed2.w
						#define SetUnderlayBias(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSpecular(val) val.Packed3.z
							#define SetSpecular(val, toSet) val.Packed3.z = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetNClipRectPos(val) val.Packed3.xy
							#define SetNClipRectPos(val, toSet) val.Packed3.xy = toSet
							#define GetSmoothness(val) val.Packed3.z
							#define SetSmoothness(val, toSet) val.Packed3.z = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetNClipRectPos(val) val.Packed2.xy
						#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayBias(val) val.Packed2.z
						#define SetUnderlayBias(val, toSet) val.Packed2.z = toSet
						#define GetUnderlayAlpha(val) val.Packed2.w
						#define SetUnderlayAlpha(val, toSet) val.Packed2.w = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetUnderlayBias(val) val.Packed2.x
						#define SetUnderlayBias(val, toSet) val.Packed2.x = toSet
						#define GetWorldNormal(val) val.Packed2.yzw
						#define SetWorldNormal(val, toSet) val.Packed2.yzw = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetSpecular(val) val.Packed3.w
							#define SetSpecular(val, toSet) val.Packed3.w = toSet
							#define GetGloss(val) val.Packed4.x
							#define SetGloss(val, toSet) val.Packed4.x = toSet
							#define GetUnderlayAlpha(val) val.Packed4.y
							#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetMetallic(val) val.Packed4.x
							#define SetMetallic(val, toSet) val.Packed4.x = toSet
							#define GetUnderlayAlpha(val) val.Packed4.y
							#define SetUnderlayAlpha(val, toSet) val.Packed4.y = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetSmoothness(val) val.Packed4.w
							#define SetSmoothness(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetUnderlayBias(val) val.Packed2.x
						#define SetUnderlayBias(val, toSet) val.Packed2.x = toSet
						#define GetUnderlayAlpha(val) val.Packed2.y
						#define SetUnderlayAlpha(val, toSet) val.Packed2.y = toSet
					#endif
				#endif
			#else
				#if defined(NOVA_CLIPPING)
					#define GetNClipRectPos(val) val.Packed0.xy
					#define SetNClipRectPos(val, toSet) val.Packed0.xy = toSet
					#define GetScaleParam(val) val.Packed0.z
					#define SetScaleParam(val, toSet) val.Packed0.z = toSet
					#define GetBiasParam(val) val.Packed0.w
					#define SetBiasParam(val, toSet) val.Packed0.w = toSet
					#if defined(NOVA_LIT)
						#define GetBiasInParam(val) val.Packed1.x
						#define SetBiasInParam(val, toSet) val.Packed1.x = toSet
						#define GetWorldNormal(val) val.Packed1.yzw
						#define SetWorldNormal(val, toSet) val.Packed1.yzw = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetSpecular(val) val.Packed2.w
							#define SetSpecular(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetGloss(val) val.Packed3.z
							#define SetGloss(val, toSet) val.Packed3.z = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetMetallic(val) val.Packed3.z
							#define SetMetallic(val, toSet) val.Packed3.z = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define GetSpecularColor(val) val.SpecularColor
							#define SetSpecularColor(val, toSet) val.SpecularColor = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetTextureUV(val) val.Packed1.xy
						#define SetTextureUV(val, toSet) val.Packed1.xy = toSet
						#define GetBiasInParam(val) val.Packed1.z
						#define SetBiasInParam(val, toSet) val.Packed1.z = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed0.xyz
						#define SetWorldNormal(val, toSet) val.Packed0.xyz = toSet
						#define GetScaleParam(val) val.Packed0.w
						#define SetScaleParam(val, toSet) val.Packed0.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetBiasInParam(val) val.Packed1.w
							#define SetBiasInParam(val, toSet) val.Packed1.w = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetBiasParam(val) val.Packed2.z
							#define SetBiasParam(val, toSet) val.Packed2.z = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetBiasInParam(val) val.Packed1.x
							#define SetBiasInParam(val, toSet) val.Packed1.x = toSet
							#define GetBiasParam(val) val.Packed1.y
							#define SetBiasParam(val, toSet) val.Packed1.y = toSet
							#define GetSpecular(val) val.Packed1.z
							#define SetSpecular(val, toSet) val.Packed1.z = toSet
							#define GetGloss(val) val.Packed1.w
							#define SetGloss(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetBiasInParam(val) val.Packed1.x
							#define SetBiasInParam(val, toSet) val.Packed1.x = toSet
							#define GetBiasParam(val) val.Packed1.y
							#define SetBiasParam(val, toSet) val.Packed1.y = toSet
							#define GetSmoothness(val) val.Packed1.z
							#define SetSmoothness(val, toSet) val.Packed1.z = toSet
							#define GetMetallic(val) val.Packed1.w
							#define SetMetallic(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetBiasInParam(val) val.Packed1.w
							#define SetBiasInParam(val, toSet) val.Packed1.w = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetBiasParam(val) val.Packed2.z
							#define SetBiasParam(val, toSet) val.Packed2.z = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetSpecularColor(val) val.SpecularColor
							#define SetSpecularColor(val, toSet) val.SpecularColor = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#endif
					#else
						#define GetTextureUV(val) val.Packed0.xy
						#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
						#define GetScaleParam(val) val.Packed0.z
						#define SetScaleParam(val, toSet) val.Packed0.z = toSet
						#define GetBiasParam(val) val.Packed0.w
						#define SetBiasParam(val, toSet) val.Packed0.w = toSet
						#define GetBiasInParam(val) val.BiasInParam
						#define SetBiasInParam(val, toSet) val.BiasInParam = toSet
					#endif
				#endif
			#endif
		#endif
	#else
		#if defined(UNDERLAY_INNER)
			#define GetTextureUV(val) val.Packed0.xy
			#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
			#define GetUnderlayUV(val) val.Packed0.zw
			#define SetUnderlayUV(val, toSet) val.Packed0.zw = toSet
			#define GetScaleParam(val) val.Packed1.x
			#define SetScaleParam(val, toSet) val.Packed1.x = toSet
			#define GetBiasParam(val) val.Packed1.y
			#define SetBiasParam(val, toSet) val.Packed1.y = toSet
			#define GetUnderlayScale(val) val.Packed1.z
			#define SetUnderlayScale(val, toSet) val.Packed1.z = toSet
			#define GetUnderlayBias(val) val.Packed1.w
			#define SetUnderlayBias(val, toSet) val.Packed1.w = toSet
			#if defined(UNDERLAY_ON)
				#if defined(NOVA_CLIPPING)
					#define GetUnderlayScale(val) val.Packed2.x
					#define SetUnderlayScale(val, toSet) val.Packed2.x = toSet
					#define GetUnderlayBias(val) val.Packed2.y
					#define SetUnderlayBias(val, toSet) val.Packed2.y = toSet
					#define GetNClipRectPos(val) val.Packed2.zw
					#define SetNClipRectPos(val, toSet) val.Packed2.zw = toSet
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayUV(val) val.Packed4.xy
							#define SetUnderlayUV(val, toSet) val.Packed4.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.x
							#define SetUnderlayAlpha(val, toSet) val.Packed5.x = toSet
							#define GetUnderlayAlpha(val) val.Packed5.y
							#define SetUnderlayAlpha(val, toSet) val.Packed5.y = toSet
							#define GetWorldNormal(val) half3(val.Packed3.w, val.Packed4.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed3.w = toSet.x; \
								val.Packed4.zw = toSet.yz;
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSpecular(val) val.Packed3.w
							#define SetSpecular(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetGloss(val) val.Packed4.w
							#define SetGloss(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetMetallic(val) val.Packed4.w
							#define SetMetallic(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed5.z
							#define SetUnderlayAlpha(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetSmoothness(val) val.Packed3.w
							#define SetSmoothness(val, toSet) val.Packed3.w = toSet
							#define GetSpecularColor(val) val.Packed4.xyz
							#define SetSpecularColor(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define GetWorldPos(val) val.Packed5.xyz
							#define SetWorldPos(val, toSet) val.Packed5.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define GetUnderlayUV(val) val.UnderlayUV
							#define SetUnderlayUV(val, toSet) val.UnderlayUV = toSet
							#define POST_NOVA_0 8
							#define POST_NOVA_1 9
							#define POST_NOVA_2 10
							#define POST_NOVA_3 11
							#define POST_NOVA_4 12
							#define POST_NOVA_5 13
						#endif
					#else
						#define GetUnderlayUV(val) val.Packed3.xy
						#define SetUnderlayUV(val, toSet) val.Packed3.xy = toSet
						#define GetUnderlayAlpha(val) val.Packed3.z
						#define SetUnderlayAlpha(val, toSet) val.Packed3.z = toSet
						#define GetUnderlayAlpha(val) val.Packed3.w
						#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed2.xyz
						#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
						#define GetUnderlayScale(val) val.Packed2.w
						#define SetUnderlayScale(val, toSet) val.Packed2.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayUV(val) val.Packed4.xy
							#define SetUnderlayUV(val, toSet) val.Packed4.xy = toSet
							#define GetUnderlayAlpha(val) val.Packed4.z
							#define SetUnderlayAlpha(val, toSet) val.Packed4.z = toSet
							#define GetUnderlayAlpha(val) val.Packed4.w
							#define SetUnderlayAlpha(val, toSet) val.Packed4.w = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayUV(val) val.Packed4.xy
							#define SetUnderlayUV(val, toSet) val.Packed4.xy = toSet
							#define GetSpecular(val) val.Packed4.z
							#define SetSpecular(val, toSet) val.Packed4.z = toSet
							#define GetGloss(val) val.Packed4.w
							#define SetGloss(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayAlpha(val) val.Packed5.x
							#define SetUnderlayAlpha(val, toSet) val.Packed5.x = toSet
							#define GetUnderlayAlpha(val) val.Packed5.y
							#define SetUnderlayAlpha(val, toSet) val.Packed5.y = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayBias(val) val.Packed3.w
							#define SetUnderlayBias(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayUV(val) val.Packed4.xy
							#define SetUnderlayUV(val, toSet) val.Packed4.xy = toSet
							#define GetSmoothness(val) val.Packed4.z
							#define SetSmoothness(val, toSet) val.Packed4.z = toSet
							#define GetMetallic(val) val.Packed4.w
							#define SetMetallic(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayAlpha(val) val.Packed5.x
							#define SetUnderlayAlpha(val, toSet) val.Packed5.x = toSet
							#define GetUnderlayAlpha(val) val.Packed5.y
							#define SetUnderlayAlpha(val, toSet) val.Packed5.y = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetSpecularColor(val) val.Packed3.xyz
							#define SetSpecularColor(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldPos(val) val.Packed4.xyz
							#define SetWorldPos(val, toSet) val.Packed4.xyz = toSet
							#define GetUnderlayBias(val) val.Packed4.w
							#define SetUnderlayBias(val, toSet) val.Packed4.w = toSet
							#define GetUnderlayUV(val) val.Packed5.xy
							#define SetUnderlayUV(val, toSet) val.Packed5.xy = toSet
							#define GetSmoothness(val) val.Packed5.z
							#define SetSmoothness(val, toSet) val.Packed5.z = toSet
							#define GetUnderlayAlpha(val) val.Packed5.w
							#define SetUnderlayAlpha(val, toSet) val.Packed5.w = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetUnderlayUV(val) val.Packed2.xy
						#define SetUnderlayUV(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayScale(val) val.Packed2.z
						#define SetUnderlayScale(val, toSet) val.Packed2.z = toSet
						#define GetUnderlayBias(val) val.Packed2.w
						#define SetUnderlayBias(val, toSet) val.Packed2.w = toSet
						#define GetUnderlayAlpha(val) val.Packed3.x
						#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
						#define GetUnderlayAlpha(val) val.Packed3.y
						#define SetUnderlayAlpha(val, toSet) val.Packed3.y = toSet
					#endif
				#endif
			#else
				#if defined(NOVA_CLIPPING)
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define GetNClipRectPos(val) half2(val.Packed2.w, val.Packed3.w)
							#define SetNClipRectPos(val, toSet) \
								val.Packed2.w = toSet.x; \
								val.Packed3.w = toSet.y;
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetNClipRectPos(val) val.Packed2.xy
							#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
							#define GetSpecular(val) val.Packed2.z
							#define SetSpecular(val, toSet) val.Packed2.z = toSet
							#define GetGloss(val) val.Packed2.w
							#define SetGloss(val, toSet) val.Packed2.w = toSet
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldNormal(val) val.WorldNormal
							#define SetWorldNormal(val, toSet) val.WorldNormal = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetNClipRectPos(val) val.Packed2.xy
							#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
							#define GetSmoothness(val) val.Packed2.z
							#define SetSmoothness(val, toSet) val.Packed2.z = toSet
							#define GetMetallic(val) val.Packed2.w
							#define SetMetallic(val, toSet) val.Packed2.w = toSet
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldNormal(val) val.WorldNormal
							#define SetWorldNormal(val, toSet) val.WorldNormal = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed2.xyz
							#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetNClipRectPos(val) val.Packed2.xy
						#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayAlpha(val) val.Packed2.z
						#define SetUnderlayAlpha(val, toSet) val.Packed2.z = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed2.w
							#define SetUnderlayAlpha(val, toSet) val.Packed2.w = toSet
							#define GetWorldNormal(val) val.WorldNormal
							#define SetWorldNormal(val, toSet) val.WorldNormal = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldNormal(val) val.Packed2.xyz
							#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
							#define GetSpecular(val) val.Packed2.w
							#define SetSpecular(val, toSet) val.Packed2.w = toSet
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldNormal(val) val.Packed2.xyz
							#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed2.xyz
							#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#endif
					#else
						#define GetUnderlayAlpha(val) val.UnderlayAlpha
						#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
					#endif
				#endif
			#endif
		#else
			#if defined(UNDERLAY_ON)
				#define GetTextureUV(val) val.Packed0.xy
				#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
				#define GetUnderlayUV(val) val.Packed0.zw
				#define SetUnderlayUV(val, toSet) val.Packed0.zw = toSet
				#define GetScaleParam(val) val.Packed1.x
				#define SetScaleParam(val, toSet) val.Packed1.x = toSet
				#define GetBiasParam(val) val.Packed1.y
				#define SetBiasParam(val, toSet) val.Packed1.y = toSet
				#define GetUnderlayScale(val) val.Packed1.z
				#define SetUnderlayScale(val, toSet) val.Packed1.z = toSet
				#define GetUnderlayBias(val) val.Packed1.w
				#define SetUnderlayBias(val, toSet) val.Packed1.w = toSet
				#if defined(NOVA_CLIPPING)
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetWorldNormal(val) val.Packed3.xyz
							#define SetWorldNormal(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define GetNClipRectPos(val) half2(val.Packed2.w, val.Packed3.w)
							#define SetNClipRectPos(val, toSet) \
								val.Packed2.w = toSet.x; \
								val.Packed3.w = toSet.y;
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetNClipRectPos(val) val.Packed2.xy
							#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
							#define GetSpecular(val) val.Packed2.z
							#define SetSpecular(val, toSet) val.Packed2.z = toSet
							#define GetGloss(val) val.Packed2.w
							#define SetGloss(val, toSet) val.Packed2.w = toSet
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldNormal(val) val.WorldNormal
							#define SetWorldNormal(val, toSet) val.WorldNormal = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetNClipRectPos(val) val.Packed2.xy
							#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
							#define GetSmoothness(val) val.Packed2.z
							#define SetSmoothness(val, toSet) val.Packed2.z = toSet
							#define GetMetallic(val) val.Packed2.w
							#define SetMetallic(val, toSet) val.Packed2.w = toSet
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed3.w
							#define SetUnderlayAlpha(val, toSet) val.Packed3.w = toSet
							#define GetWorldNormal(val) val.WorldNormal
							#define SetWorldNormal(val, toSet) val.WorldNormal = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed2.xyz
							#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define GetNClipRectPos(val) val.NClipRectPos
							#define SetNClipRectPos(val, toSet) val.NClipRectPos = toSet
							#define POST_NOVA_0 7
							#define POST_NOVA_1 8
							#define POST_NOVA_2 9
							#define POST_NOVA_3 10
							#define POST_NOVA_4 11
							#define POST_NOVA_5 12
						#endif
					#else
						#define GetNClipRectPos(val) val.Packed2.xy
						#define SetNClipRectPos(val, toSet) val.Packed2.xy = toSet
						#define GetUnderlayAlpha(val) val.Packed2.z
						#define SetUnderlayAlpha(val, toSet) val.Packed2.z = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetUnderlayAlpha(val) val.Packed2.w
							#define SetUnderlayAlpha(val, toSet) val.Packed2.w = toSet
							#define GetWorldNormal(val) val.WorldNormal
							#define SetWorldNormal(val, toSet) val.WorldNormal = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldNormal(val) val.Packed2.xyz
							#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
							#define GetSpecular(val) val.Packed2.w
							#define SetSpecular(val, toSet) val.Packed2.w = toSet
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetGloss(val) val.Packed3.w
							#define SetGloss(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldNormal(val) val.Packed2.xyz
							#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetWorldPos(val) val.Packed3.xyz
							#define SetWorldPos(val, toSet) val.Packed3.xyz = toSet
							#define GetMetallic(val) val.Packed3.w
							#define SetMetallic(val, toSet) val.Packed3.w = toSet
							#define GetUnderlayAlpha(val) val.UnderlayAlpha
							#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed2.xyz
							#define SetWorldNormal(val, toSet) val.Packed2.xyz = toSet
							#define GetSmoothness(val) val.Packed2.w
							#define SetSmoothness(val, toSet) val.Packed2.w = toSet
							#define GetUnderlayAlpha(val) val.Packed3.x
							#define SetUnderlayAlpha(val, toSet) val.Packed3.x = toSet
							#define GetSpecularColor(val) val.Packed3.yzw
							#define SetSpecularColor(val, toSet) val.Packed3.yzw = toSet
							#define GetWorldPos(val) val.WorldPos
							#define SetWorldPos(val, toSet) val.WorldPos = toSet
							#define POST_NOVA_0 6
							#define POST_NOVA_1 7
							#define POST_NOVA_2 8
							#define POST_NOVA_3 9
							#define POST_NOVA_4 10
							#define POST_NOVA_5 11
						#endif
					#else
						#define GetUnderlayAlpha(val) val.UnderlayAlpha
						#define SetUnderlayAlpha(val, toSet) val.UnderlayAlpha = toSet
					#endif
				#endif
			#else
				#if defined(NOVA_CLIPPING)
					#define GetScaleParam(val) val.Packed0.x
					#define SetScaleParam(val, toSet) val.Packed0.x = toSet
					#define GetBiasParam(val) val.Packed0.y
					#define SetBiasParam(val, toSet) val.Packed0.y = toSet
					#define GetNClipRectPos(val) val.Packed0.zw
					#define SetNClipRectPos(val, toSet) val.Packed0.zw = toSet
					#if defined(NOVA_LIT)
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetWorldNormal(val) half3(val.Packed1.w, val.Packed2.zw)
							#define SetWorldNormal(val, toSet) \
								val.Packed1.w = toSet.x; \
								val.Packed2.zw = toSet.yz;
							#define POST_NOVA_0 4
							#define POST_NOVA_1 5
							#define POST_NOVA_2 6
							#define POST_NOVA_3 7
							#define POST_NOVA_4 8
							#define POST_NOVA_5 9
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldNormal(val) val.Packed1.xyz
							#define SetWorldNormal(val, toSet) val.Packed1.xyz = toSet
							#define GetSpecular(val) val.Packed1.w
							#define SetSpecular(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetGloss(val) val.Packed2.w
							#define SetGloss(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldNormal(val) val.Packed1.xyz
							#define SetWorldNormal(val, toSet) val.Packed1.xyz = toSet
							#define GetSmoothness(val) val.Packed1.w
							#define SetSmoothness(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetMetallic(val) val.Packed2.w
							#define SetMetallic(val, toSet) val.Packed2.w = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldNormal(val) val.Packed1.xyz
							#define SetWorldNormal(val, toSet) val.Packed1.xyz = toSet
							#define GetSmoothness(val) val.Packed1.w
							#define SetSmoothness(val, toSet) val.Packed1.w = toSet
							#define GetWorldPos(val) val.Packed2.xyz
							#define SetWorldPos(val, toSet) val.Packed2.xyz = toSet
							#define GetTextureUV(val) val.Packed3.xy
							#define SetTextureUV(val, toSet) val.Packed3.xy = toSet
							#define GetSpecularColor(val) fixed3(val.Packed2.w, val.Packed3.zw)
							#define SetSpecularColor(val, toSet) \
								val.Packed2.w = toSet.x; \
								val.Packed3.zw = toSet.yz;
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#endif
					#else
						#define GetTextureUV(val) val.TextureUV
						#define SetTextureUV(val, toSet) val.TextureUV = toSet
					#endif
				#else
					#if defined(NOVA_LIT)
						#define GetWorldNormal(val) val.Packed0.xyz
						#define SetWorldNormal(val, toSet) val.Packed0.xyz = toSet
						#define GetScaleParam(val) val.Packed0.w
						#define SetScaleParam(val, toSet) val.Packed0.w = toSet
						#if defined(NOVA_LAMBERT_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetBiasParam(val) val.Packed1.w
							#define SetBiasParam(val, toSet) val.Packed1.w = toSet
							#define GetTextureUV(val) val.TextureUV
							#define SetTextureUV(val, toSet) val.TextureUV = toSet
							#define POST_NOVA_0 4
							#define POST_NOVA_1 5
							#define POST_NOVA_2 6
							#define POST_NOVA_3 7
							#define POST_NOVA_4 8
							#define POST_NOVA_5 9
						#elif defined(NOVA_BLINNPHONG_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetBiasParam(val) val.Packed1.w
							#define SetBiasParam(val, toSet) val.Packed1.w = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetSpecular(val) val.Packed2.z
							#define SetSpecular(val, toSet) val.Packed2.z = toSet
							#define GetGloss(val) val.Packed2.w
							#define SetGloss(val, toSet) val.Packed2.w = toSet
							#define POST_NOVA_0 4
							#define POST_NOVA_1 5
							#define POST_NOVA_2 6
							#define POST_NOVA_3 7
							#define POST_NOVA_4 8
							#define POST_NOVA_5 9
						#elif defined(NOVA_STANDARD_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetBiasParam(val) val.Packed1.w
							#define SetBiasParam(val, toSet) val.Packed1.w = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetSmoothness(val) val.Packed2.z
							#define SetSmoothness(val, toSet) val.Packed2.z = toSet
							#define GetMetallic(val) val.Packed2.w
							#define SetMetallic(val, toSet) val.Packed2.w = toSet
							#define POST_NOVA_0 4
							#define POST_NOVA_1 5
							#define POST_NOVA_2 6
							#define POST_NOVA_3 7
							#define POST_NOVA_4 8
							#define POST_NOVA_5 9
						#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
							#define GetWorldPos(val) val.Packed1.xyz
							#define SetWorldPos(val, toSet) val.Packed1.xyz = toSet
							#define GetBiasParam(val) val.Packed1.w
							#define SetBiasParam(val, toSet) val.Packed1.w = toSet
							#define GetTextureUV(val) val.Packed2.xy
							#define SetTextureUV(val, toSet) val.Packed2.xy = toSet
							#define GetSmoothness(val) val.Packed2.z
							#define SetSmoothness(val, toSet) val.Packed2.z = toSet
							#define GetSpecularColor(val) val.SpecularColor
							#define SetSpecularColor(val, toSet) val.SpecularColor = toSet
							#define POST_NOVA_0 5
							#define POST_NOVA_1 6
							#define POST_NOVA_2 7
							#define POST_NOVA_3 8
							#define POST_NOVA_4 9
							#define POST_NOVA_5 10
						#endif
					#else
						#define GetTextureUV(val) val.Packed0.xy
						#define SetTextureUV(val, toSet) val.Packed0.xy = toSet
						#define GetScaleParam(val) val.Packed0.z
						#define SetScaleParam(val, toSet) val.Packed0.z = toSet
						#define GetBiasParam(val) val.Packed0.w
						#define SetBiasParam(val, toSet) val.Packed0.w = toSet
					#endif
				#endif
			#endif
		#endif
	#endif
#endif

struct v2f
{
	float4 pos : SV_POSITION;
	fixed4 FaceColor : TEXCOORD0;
	#if defined(USES_BIAS_OUT)
		#if defined(OUTLINE_ON)
			// x: ScaleParam
			// y: BiasParam
			// z: BiasOutParam
			// w: BiasInParam
			half4 Packed0 : TEXCOORD1;
			fixed4 OutlineColor : TEXCOORD2;
			#if defined(UNDERLAY_INNER)
				// xy: TextureUV
				// zw: UnderlayUV
				float4 Packed1 : TEXCOORD3;
				#if defined(UNDERLAY_ON)
					// x: UnderlayScale
					// y: UnderlayBias
					// z: UnderlayScale
					// w: UnderlayBias
					half4 Packed2 : TEXCOORD4;
					#if defined(NOVA_CLIPPING)
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed3 : TEXCOORD5;
								// xy: UnderlayUV
								// zw: WorldNormal(yz)
								float4 Packed4 : TEXCOORD6;
								// xy: NClipRectPos
								// z: UnderlayAlpha
								// w: UnderlayAlpha
								half4 Packed5 : TEXCOORD7;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xy: NClipRectPos
								// z: Specular
								// w: Gloss
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// zw: WorldNormal(yz)
								float4 Packed5 : TEXCOORD7;
								// x: UnderlayAlpha
								// y: UnderlayAlpha
								fixed2 Packed6 : TEXCOORD8;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xy: NClipRectPos
								// z: Smoothness
								// w: Metallic
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// zw: WorldNormal(yz)
								float4 Packed5 : TEXCOORD7;
								// x: UnderlayAlpha
								// y: UnderlayAlpha
								fixed2 Packed6 : TEXCOORD8;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD5;
								// xyz: SpecularColor
								// w: UnderlayAlpha
								fixed4 Packed4 : TEXCOORD6;
								// xyz: WorldPos
								// w: NClipRectPos(x)
								float4 Packed5 : TEXCOORD7;
								// xy: UnderlayUV
								// z: NClipRectPos(y)
								// w: UnderlayAlpha
								float4 Packed6 : TEXCOORD8;
							#endif
						#else
							// xy: UnderlayUV
							// zw: NClipRectPos
							float4 Packed3 : TEXCOORD5;
							// x: UnderlayAlpha
							// y: UnderlayAlpha
							fixed2 Packed4 : TEXCOORD6;
						#endif
					#else
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed3 : TEXCOORD5;
								// xy: UnderlayUV
								// zw: WorldNormal(yz)
								float4 Packed4 : TEXCOORD6;
								// x: UnderlayAlpha
								// y: UnderlayAlpha
								fixed2 Packed5 : TEXCOORD7;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldNormal
								// w: Specular
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Gloss
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD7;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Metallic
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD7;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD5;
								// xyz: SpecularColor
								// w: UnderlayAlpha
								fixed4 Packed4 : TEXCOORD6;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD7;
								float2 UnderlayUV : TEXCOORD8;
							#endif
						#else
							// xy: UnderlayUV
							// z: UnderlayAlpha
							// w: UnderlayAlpha
							float4 Packed3 : TEXCOORD5;
						#endif
					#endif
				#else
					#if defined(NOVA_CLIPPING)
						// x: UnderlayScale
						// y: UnderlayBias
						// zw: NClipRectPos
						half4 Packed2 : TEXCOORD4;
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD5;
								half3 WorldNormal : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldNormal
								// w: Specular
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Gloss
								float4 Packed4 : TEXCOORD6;
								fixed UnderlayAlpha : TEXCOORD7;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Metallic
								float4 Packed4 : TEXCOORD6;
								fixed UnderlayAlpha : TEXCOORD7;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD5;
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed4 : TEXCOORD6;
								float3 WorldPos : TEXCOORD7;
							#endif
						#else
							fixed UnderlayAlpha : TEXCOORD5;
						#endif
					#else
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayScale
							half4 Packed2 : TEXCOORD4;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD5;
								fixed UnderlayAlpha : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD5;
								// x: Specular
								// y: Gloss
								// z: UnderlayAlpha
								half3 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD5;
								// x: Smoothness
								// y: Metallic
								// z: UnderlayAlpha
								half3 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed4 : TEXCOORD6;
								half Smoothness : TEXCOORD7;
							#endif
						#else
							// x: UnderlayScale
							// y: UnderlayBias
							// z: UnderlayAlpha
							half3 Packed2 : TEXCOORD4;
						#endif
					#endif
				#endif
			#else
				#if defined(UNDERLAY_ON)
					// xy: TextureUV
					// zw: UnderlayUV
					float4 Packed1 : TEXCOORD3;
					#if defined(NOVA_CLIPPING)
						// x: UnderlayScale
						// y: UnderlayBias
						// zw: NClipRectPos
						half4 Packed2 : TEXCOORD4;
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD5;
								half3 WorldNormal : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldNormal
								// w: Specular
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Gloss
								float4 Packed4 : TEXCOORD6;
								fixed UnderlayAlpha : TEXCOORD7;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Metallic
								float4 Packed4 : TEXCOORD6;
								fixed UnderlayAlpha : TEXCOORD7;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD5;
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed4 : TEXCOORD6;
								float3 WorldPos : TEXCOORD7;
							#endif
						#else
							fixed UnderlayAlpha : TEXCOORD5;
						#endif
					#else
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayScale
							half4 Packed2 : TEXCOORD4;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD5;
								fixed UnderlayAlpha : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD5;
								// x: Specular
								// y: Gloss
								// z: UnderlayAlpha
								half3 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD5;
								// x: Smoothness
								// y: Metallic
								// z: UnderlayAlpha
								half3 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed4 : TEXCOORD6;
								half Smoothness : TEXCOORD7;
							#endif
						#else
							// x: UnderlayScale
							// y: UnderlayBias
							// z: UnderlayAlpha
							half3 Packed2 : TEXCOORD4;
						#endif
					#endif
				#else
					#if defined(NOVA_CLIPPING)
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed1 : TEXCOORD3;
								// xy: TextureUV
								// zw: WorldNormal(yz)
								float4 Packed2 : TEXCOORD4;
								half2 NClipRectPos : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xy: NClipRectPos
								// z: Specular
								// w: Gloss
								half4 Packed1 : TEXCOORD3;
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed2 : TEXCOORD4;
								// xy: TextureUV
								// zw: WorldNormal(yz)
								float4 Packed3 : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xy: NClipRectPos
								// z: Smoothness
								// w: Metallic
								half4 Packed1 : TEXCOORD3;
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed2 : TEXCOORD4;
								// xy: TextureUV
								// zw: WorldNormal(yz)
								float4 Packed3 : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed1 : TEXCOORD3;
								// xyz: WorldPos
								// w: NClipRectPos(x)
								float4 Packed2 : TEXCOORD4;
								// xy: TextureUV
								// z: NClipRectPos(y)
								float3 Packed3 : TEXCOORD5;
								fixed3 SpecularColor : TEXCOORD6;
							#endif
						#else
							// xy: TextureUV
							// zw: NClipRectPos
							float4 Packed1 : TEXCOORD3;
						#endif
					#else
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed1 : TEXCOORD3;
								// xy: TextureUV
								// zw: WorldNormal(yz)
								float4 Packed2 : TEXCOORD4;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldNormal
								// w: Specular
								half4 Packed1 : TEXCOORD3;
								// xyz: WorldPos
								// w: Gloss
								float4 Packed2 : TEXCOORD4;
								float2 TextureUV : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed1 : TEXCOORD3;
								// xyz: WorldPos
								// w: Metallic
								float4 Packed2 : TEXCOORD4;
								float2 TextureUV : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed1 : TEXCOORD3;
								// xyz: WorldPos
								// w: SpecularColor(x)
								float4 Packed2 : TEXCOORD4;
								// xy: TextureUV
								// zw: SpecularColor(yz)
								float4 Packed3 : TEXCOORD5;
							#endif
						#else
							float2 TextureUV : TEXCOORD3;
						#endif
					#endif
				#endif
			#endif
		#else
			#if defined(UNDERLAY_INNER)
				// xy: TextureUV
				// zw: UnderlayUV
				float4 Packed0 : TEXCOORD1;
				// x: ScaleParam
				// y: BiasParam
				// z: BiasOutParam
				// w: UnderlayScale
				half4 Packed1 : TEXCOORD2;
				#if defined(UNDERLAY_ON)
					#if defined(NOVA_CLIPPING)
						// xy: NClipRectPos
						// z: UnderlayBias
						// w: UnderlayScale
						half4 Packed2 : TEXCOORD3;
						#if defined(NOVA_LIT)
							// x: UnderlayBias
							// yzw: WorldNormal
							half4 Packed3 : TEXCOORD4;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								float3 Packed5 : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: Specular
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: Gloss
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD6;
								fixed UnderlayAlpha : TEXCOORD7;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: Metallic
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD6;
								fixed UnderlayAlpha : TEXCOORD7;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: SpecularColor
								// w: UnderlayAlpha
								fixed4 Packed4 : TEXCOORD5;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed5 : TEXCOORD6;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								float3 Packed6 : TEXCOORD7;
							#endif
						#else
							// xy: UnderlayUV
							// z: UnderlayBias
							// w: UnderlayAlpha
							float4 Packed3 : TEXCOORD4;
							fixed UnderlayAlpha : TEXCOORD5;
						#endif
					#else
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayBias
							half4 Packed2 : TEXCOORD3;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD4;
								// xy: UnderlayUV
								// z: UnderlayScale
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
								fixed UnderlayAlpha : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// x: UnderlayBias
								// y: UnderlayScale
								// z: Specular
								// w: Gloss
								half4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								float3 Packed5 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// x: UnderlayBias
								// y: UnderlayScale
								// z: Smoothness
								// w: Metallic
								half4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								float3 Packed5 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: SpecularColor
								// w: UnderlayAlpha
								fixed4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: UnderlayScale
								// w: Smoothness
								float4 Packed5 : TEXCOORD6;
								fixed UnderlayAlpha : TEXCOORD7;
							#endif
						#else
							// xy: UnderlayUV
							// z: UnderlayBias
							// w: UnderlayScale
							float4 Packed2 : TEXCOORD3;
							// x: UnderlayBias
							// y: UnderlayAlpha
							// z: UnderlayAlpha
							half3 Packed3 : TEXCOORD4;
						#endif
					#endif
				#else
					#if defined(NOVA_CLIPPING)
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayBias
							half4 Packed2 : TEXCOORD3;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD4;
								half2 NClipRectPos : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xy: NClipRectPos
								// z: Specular
								// w: Gloss
								half4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xy: NClipRectPos
								// z: Smoothness
								// w: Metallic
								half4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD5;
								half2 NClipRectPos : TEXCOORD6;
							#endif
						#else
							// xy: NClipRectPos
							// z: UnderlayBias
							// w: UnderlayAlpha
							half4 Packed2 : TEXCOORD3;
						#endif
					#else
						#if defined(NOVA_LIT)
							// x: UnderlayBias
							// yzw: WorldNormal
							half4 Packed2 : TEXCOORD3;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD4;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: Specular
								float4 Packed3 : TEXCOORD4;
								// x: Gloss
								// y: UnderlayAlpha
								half2 Packed4 : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed3 : TEXCOORD4;
								// x: Metallic
								// y: UnderlayAlpha
								half2 Packed4 : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD5;
							#endif
						#else
							// x: UnderlayBias
							// y: UnderlayAlpha
							half2 Packed2 : TEXCOORD3;
						#endif
					#endif
				#endif
			#else
				#if defined(UNDERLAY_ON)
					// xy: TextureUV
					// zw: UnderlayUV
					float4 Packed0 : TEXCOORD1;
					// x: ScaleParam
					// y: BiasParam
					// z: BiasOutParam
					// w: UnderlayScale
					half4 Packed1 : TEXCOORD2;
					#if defined(NOVA_CLIPPING)
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayBias
							half4 Packed2 : TEXCOORD3;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD4;
								half2 NClipRectPos : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xy: NClipRectPos
								// z: Specular
								// w: Gloss
								half4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xy: NClipRectPos
								// z: Smoothness
								// w: Metallic
								half4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD5;
								half2 NClipRectPos : TEXCOORD6;
							#endif
						#else
							// xy: NClipRectPos
							// z: UnderlayBias
							// w: UnderlayAlpha
							half4 Packed2 : TEXCOORD3;
						#endif
					#else
						#if defined(NOVA_LIT)
							// x: UnderlayBias
							// yzw: WorldNormal
							half4 Packed2 : TEXCOORD3;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD4;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: Specular
								float4 Packed3 : TEXCOORD4;
								// x: Gloss
								// y: UnderlayAlpha
								half2 Packed4 : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed3 : TEXCOORD4;
								// x: Metallic
								// y: UnderlayAlpha
								half2 Packed4 : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD5;
							#endif
						#else
							// x: UnderlayBias
							// y: UnderlayAlpha
							half2 Packed2 : TEXCOORD3;
						#endif
					#endif
				#else
					#if defined(NOVA_CLIPPING)
						// xy: NClipRectPos
						// z: ScaleParam
						// w: BiasParam
						half4 Packed0 : TEXCOORD1;
						#if defined(NOVA_LIT)
							// x: BiasOutParam
							// yzw: WorldNormal
							half4 Packed1 : TEXCOORD2;
							#if defined(NOVA_LAMBERT_LIGHTING)
								float3 WorldPos : TEXCOORD3;
								float2 TextureUV : TEXCOORD4;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: Specular
								float4 Packed2 : TEXCOORD3;
								// xy: TextureUV
								// z: Gloss
								float3 Packed3 : TEXCOORD4;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed2 : TEXCOORD3;
								// xy: TextureUV
								// z: Metallic
								float3 Packed3 : TEXCOORD4;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed2 : TEXCOORD3;
								float2 TextureUV : TEXCOORD4;
								fixed3 SpecularColor : TEXCOORD5;
							#endif
						#else
							// xy: TextureUV
							// z: BiasOutParam
							float3 Packed1 : TEXCOORD2;
						#endif
					#else
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: ScaleParam
							half4 Packed0 : TEXCOORD1;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: BiasOutParam
								float4 Packed1 : TEXCOORD2;
								// xy: TextureUV
								// z: BiasParam
								float3 Packed2 : TEXCOORD3;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// x: BiasOutParam
								// y: BiasParam
								// z: Specular
								// w: Gloss
								half4 Packed1 : TEXCOORD2;
								float3 WorldPos : TEXCOORD3;
								float2 TextureUV : TEXCOORD4;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// x: BiasOutParam
								// y: BiasParam
								// z: Smoothness
								// w: Metallic
								half4 Packed1 : TEXCOORD2;
								float3 WorldPos : TEXCOORD3;
								float2 TextureUV : TEXCOORD4;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldPos
								// w: BiasOutParam
								float4 Packed1 : TEXCOORD2;
								// xy: TextureUV
								// z: BiasParam
								// w: Smoothness
								float4 Packed2 : TEXCOORD3;
								fixed3 SpecularColor : TEXCOORD4;
							#endif
						#else
							// xy: TextureUV
							// z: ScaleParam
							// w: BiasParam
							float4 Packed0 : TEXCOORD1;
							half BiasOutParam : TEXCOORD2;
						#endif
					#endif
				#endif
			#endif
		#endif
	#else
		#if defined(OUTLINE_ON)
			fixed4 OutlineColor : TEXCOORD1;
			#if defined(UNDERLAY_INNER)
				// xy: TextureUV
				// zw: UnderlayUV
				float4 Packed0 : TEXCOORD2;
				// x: ScaleParam
				// y: BiasParam
				// z: BiasInParam
				// w: UnderlayScale
				half4 Packed1 : TEXCOORD3;
				#if defined(UNDERLAY_ON)
					#if defined(NOVA_CLIPPING)
						// xy: NClipRectPos
						// z: UnderlayBias
						// w: UnderlayScale
						half4 Packed2 : TEXCOORD4;
						#if defined(NOVA_LIT)
							// x: UnderlayBias
							// yzw: WorldNormal
							half4 Packed3 : TEXCOORD5;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								float3 Packed5 : TEXCOORD7;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: Specular
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// z: Gloss
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD7;
								fixed UnderlayAlpha : TEXCOORD8;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// z: Metallic
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD7;
								fixed UnderlayAlpha : TEXCOORD8;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: SpecularColor
								// w: UnderlayAlpha
								fixed4 Packed4 : TEXCOORD6;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed5 : TEXCOORD7;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								float3 Packed6 : TEXCOORD8;
							#endif
						#else
							// xy: UnderlayUV
							// z: UnderlayBias
							// w: UnderlayAlpha
							float4 Packed3 : TEXCOORD5;
							fixed UnderlayAlpha : TEXCOORD6;
						#endif
					#else
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayBias
							half4 Packed2 : TEXCOORD4;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD5;
								// xy: UnderlayUV
								// z: UnderlayScale
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD6;
								fixed UnderlayAlpha : TEXCOORD7;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// x: UnderlayBias
								// y: UnderlayScale
								// z: Specular
								// w: Gloss
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								float3 Packed5 : TEXCOORD7;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// x: UnderlayBias
								// y: UnderlayScale
								// z: Smoothness
								// w: Metallic
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								float3 Packed5 : TEXCOORD7;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: SpecularColor
								// w: UnderlayAlpha
								fixed4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed4 : TEXCOORD6;
								// xy: UnderlayUV
								// z: UnderlayScale
								// w: Smoothness
								float4 Packed5 : TEXCOORD7;
								fixed UnderlayAlpha : TEXCOORD8;
							#endif
						#else
							// xy: UnderlayUV
							// z: UnderlayBias
							// w: UnderlayScale
							float4 Packed2 : TEXCOORD4;
							// x: UnderlayBias
							// y: UnderlayAlpha
							// z: UnderlayAlpha
							half3 Packed3 : TEXCOORD5;
						#endif
					#endif
				#else
					#if defined(NOVA_CLIPPING)
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayBias
							half4 Packed2 : TEXCOORD4;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD5;
								half2 NClipRectPos : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xy: NClipRectPos
								// z: Specular
								// w: Gloss
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xy: NClipRectPos
								// z: Smoothness
								// w: Metallic
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD6;
								half2 NClipRectPos : TEXCOORD7;
							#endif
						#else
							// xy: NClipRectPos
							// z: UnderlayBias
							// w: UnderlayAlpha
							half4 Packed2 : TEXCOORD4;
						#endif
					#else
						#if defined(NOVA_LIT)
							// x: UnderlayBias
							// yzw: WorldNormal
							half4 Packed2 : TEXCOORD4;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: Specular
								float4 Packed3 : TEXCOORD5;
								// x: Gloss
								// y: UnderlayAlpha
								half2 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed3 : TEXCOORD5;
								// x: Metallic
								// y: UnderlayAlpha
								half2 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD6;
							#endif
						#else
							// x: UnderlayBias
							// y: UnderlayAlpha
							half2 Packed2 : TEXCOORD4;
						#endif
					#endif
				#endif
			#else
				#if defined(UNDERLAY_ON)
					// xy: TextureUV
					// zw: UnderlayUV
					float4 Packed0 : TEXCOORD2;
					// x: ScaleParam
					// y: BiasParam
					// z: BiasInParam
					// w: UnderlayScale
					half4 Packed1 : TEXCOORD3;
					#if defined(NOVA_CLIPPING)
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayBias
							half4 Packed2 : TEXCOORD4;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD5;
								half2 NClipRectPos : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xy: NClipRectPos
								// z: Specular
								// w: Gloss
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xy: NClipRectPos
								// z: Smoothness
								// w: Metallic
								half4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD6;
								half2 NClipRectPos : TEXCOORD7;
							#endif
						#else
							// xy: NClipRectPos
							// z: UnderlayBias
							// w: UnderlayAlpha
							half4 Packed2 : TEXCOORD4;
						#endif
					#else
						#if defined(NOVA_LIT)
							// x: UnderlayBias
							// yzw: WorldNormal
							half4 Packed2 : TEXCOORD4;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: Specular
								float4 Packed3 : TEXCOORD5;
								// x: Gloss
								// y: UnderlayAlpha
								half2 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed3 : TEXCOORD5;
								// x: Metallic
								// y: UnderlayAlpha
								half2 Packed4 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD5;
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed4 : TEXCOORD6;
							#endif
						#else
							// x: UnderlayBias
							// y: UnderlayAlpha
							half2 Packed2 : TEXCOORD4;
						#endif
					#endif
				#else
					#if defined(NOVA_CLIPPING)
						// xy: NClipRectPos
						// z: ScaleParam
						// w: BiasParam
						half4 Packed0 : TEXCOORD2;
						#if defined(NOVA_LIT)
							// x: BiasInParam
							// yzw: WorldNormal
							half4 Packed1 : TEXCOORD3;
							#if defined(NOVA_LAMBERT_LIGHTING)
								float3 WorldPos : TEXCOORD4;
								float2 TextureUV : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: Specular
								float4 Packed2 : TEXCOORD4;
								// xy: TextureUV
								// z: Gloss
								float3 Packed3 : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed2 : TEXCOORD4;
								// xy: TextureUV
								// z: Metallic
								float3 Packed3 : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldPos
								// w: Smoothness
								float4 Packed2 : TEXCOORD4;
								float2 TextureUV : TEXCOORD5;
								fixed3 SpecularColor : TEXCOORD6;
							#endif
						#else
							// xy: TextureUV
							// z: BiasInParam
							float3 Packed1 : TEXCOORD3;
						#endif
					#else
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: ScaleParam
							half4 Packed0 : TEXCOORD2;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: BiasInParam
								float4 Packed1 : TEXCOORD3;
								// xy: TextureUV
								// z: BiasParam
								float3 Packed2 : TEXCOORD4;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// x: BiasInParam
								// y: BiasParam
								// z: Specular
								// w: Gloss
								half4 Packed1 : TEXCOORD3;
								float3 WorldPos : TEXCOORD4;
								float2 TextureUV : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// x: BiasInParam
								// y: BiasParam
								// z: Smoothness
								// w: Metallic
								half4 Packed1 : TEXCOORD3;
								float3 WorldPos : TEXCOORD4;
								float2 TextureUV : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldPos
								// w: BiasInParam
								float4 Packed1 : TEXCOORD3;
								// xy: TextureUV
								// z: BiasParam
								// w: Smoothness
								float4 Packed2 : TEXCOORD4;
								fixed3 SpecularColor : TEXCOORD5;
							#endif
						#else
							// xy: TextureUV
							// z: ScaleParam
							// w: BiasParam
							float4 Packed0 : TEXCOORD2;
							half BiasInParam : TEXCOORD3;
						#endif
					#endif
				#endif
			#endif
		#else
			#if defined(UNDERLAY_INNER)
				// xy: TextureUV
				// zw: UnderlayUV
				float4 Packed0 : TEXCOORD1;
				// x: ScaleParam
				// y: BiasParam
				// z: UnderlayScale
				// w: UnderlayBias
				half4 Packed1 : TEXCOORD2;
				#if defined(UNDERLAY_ON)
					#if defined(NOVA_CLIPPING)
						// x: UnderlayScale
						// y: UnderlayBias
						// zw: NClipRectPos
						half4 Packed2 : TEXCOORD3;
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed3 : TEXCOORD4;
								// xy: UnderlayUV
								// zw: WorldNormal(yz)
								float4 Packed4 : TEXCOORD5;
								// x: UnderlayAlpha
								// y: UnderlayAlpha
								fixed2 Packed5 : TEXCOORD6;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldNormal
								// w: Specular
								half4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: Gloss
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: Metallic
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed3 : TEXCOORD4;
								// xyz: SpecularColor
								// w: UnderlayAlpha
								fixed4 Packed4 : TEXCOORD5;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD6;
								float2 UnderlayUV : TEXCOORD7;
							#endif
						#else
							// xy: UnderlayUV
							// z: UnderlayAlpha
							// w: UnderlayAlpha
							float4 Packed3 : TEXCOORD4;
						#endif
					#else
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: UnderlayScale
							half4 Packed2 : TEXCOORD3;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD4;
								// xy: UnderlayUV
								// z: UnderlayAlpha
								// w: UnderlayAlpha
								float4 Packed4 : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD4;
								// xy: UnderlayUV
								// z: Specular
								// w: Gloss
								float4 Packed4 : TEXCOORD5;
								// x: UnderlayAlpha
								// y: UnderlayAlpha
								fixed2 Packed5 : TEXCOORD6;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed3 : TEXCOORD4;
								// xy: UnderlayUV
								// z: Smoothness
								// w: Metallic
								float4 Packed4 : TEXCOORD5;
								// x: UnderlayAlpha
								// y: UnderlayAlpha
								fixed2 Packed5 : TEXCOORD6;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: SpecularColor
								// w: UnderlayAlpha
								fixed4 Packed3 : TEXCOORD4;
								// xyz: WorldPos
								// w: UnderlayBias
								float4 Packed4 : TEXCOORD5;
								// xy: UnderlayUV
								// z: Smoothness
								// w: UnderlayAlpha
								float4 Packed5 : TEXCOORD6;
							#endif
						#else
							// xy: UnderlayUV
							// z: UnderlayScale
							// w: UnderlayBias
							float4 Packed2 : TEXCOORD3;
							// x: UnderlayAlpha
							// y: UnderlayAlpha
							fixed2 Packed3 : TEXCOORD4;
						#endif
					#endif
				#else
					#if defined(NOVA_CLIPPING)
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: NClipRectPos(x)
								float4 Packed2 : TEXCOORD3;
								// xyz: WorldNormal
								// w: NClipRectPos(y)
								half4 Packed3 : TEXCOORD4;
								fixed UnderlayAlpha : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xy: NClipRectPos
								// z: Specular
								// w: Gloss
								half4 Packed2 : TEXCOORD3;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD4;
								half3 WorldNormal : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xy: NClipRectPos
								// z: Smoothness
								// w: Metallic
								half4 Packed2 : TEXCOORD3;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD4;
								half3 WorldNormal : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed2 : TEXCOORD3;
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD4;
								float3 WorldPos : TEXCOORD5;
								half2 NClipRectPos : TEXCOORD6;
							#endif
						#else
							// xy: NClipRectPos
							// z: UnderlayAlpha
							half3 Packed2 : TEXCOORD3;
						#endif
					#else
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed2 : TEXCOORD3;
								half3 WorldNormal : TEXCOORD4;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldNormal
								// w: Specular
								half4 Packed2 : TEXCOORD3;
								// xyz: WorldPos
								// w: Gloss
								float4 Packed3 : TEXCOORD4;
								fixed UnderlayAlpha : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed2 : TEXCOORD3;
								// xyz: WorldPos
								// w: Metallic
								float4 Packed3 : TEXCOORD4;
								fixed UnderlayAlpha : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed2 : TEXCOORD3;
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD4;
								float3 WorldPos : TEXCOORD5;
							#endif
						#else
							fixed UnderlayAlpha : TEXCOORD3;
						#endif
					#endif
				#endif
			#else
				#if defined(UNDERLAY_ON)
					// xy: TextureUV
					// zw: UnderlayUV
					float4 Packed0 : TEXCOORD1;
					// x: ScaleParam
					// y: BiasParam
					// z: UnderlayScale
					// w: UnderlayBias
					half4 Packed1 : TEXCOORD2;
					#if defined(NOVA_CLIPPING)
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: NClipRectPos(x)
								float4 Packed2 : TEXCOORD3;
								// xyz: WorldNormal
								// w: NClipRectPos(y)
								half4 Packed3 : TEXCOORD4;
								fixed UnderlayAlpha : TEXCOORD5;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xy: NClipRectPos
								// z: Specular
								// w: Gloss
								half4 Packed2 : TEXCOORD3;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD4;
								half3 WorldNormal : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xy: NClipRectPos
								// z: Smoothness
								// w: Metallic
								half4 Packed2 : TEXCOORD3;
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed3 : TEXCOORD4;
								half3 WorldNormal : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed2 : TEXCOORD3;
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD4;
								float3 WorldPos : TEXCOORD5;
								half2 NClipRectPos : TEXCOORD6;
							#endif
						#else
							// xy: NClipRectPos
							// z: UnderlayAlpha
							half3 Packed2 : TEXCOORD3;
						#endif
					#else
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: UnderlayAlpha
								float4 Packed2 : TEXCOORD3;
								half3 WorldNormal : TEXCOORD4;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldNormal
								// w: Specular
								half4 Packed2 : TEXCOORD3;
								// xyz: WorldPos
								// w: Gloss
								float4 Packed3 : TEXCOORD4;
								fixed UnderlayAlpha : TEXCOORD5;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed2 : TEXCOORD3;
								// xyz: WorldPos
								// w: Metallic
								float4 Packed3 : TEXCOORD4;
								fixed UnderlayAlpha : TEXCOORD5;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed2 : TEXCOORD3;
								// x: UnderlayAlpha
								// yzw: SpecularColor
								fixed4 Packed3 : TEXCOORD4;
								float3 WorldPos : TEXCOORD5;
							#endif
						#else
							fixed UnderlayAlpha : TEXCOORD3;
						#endif
					#endif
				#else
					#if defined(NOVA_CLIPPING)
						// x: ScaleParam
						// y: BiasParam
						// zw: NClipRectPos
						half4 Packed0 : TEXCOORD1;
						#if defined(NOVA_LIT)
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: WorldNormal(x)
								float4 Packed1 : TEXCOORD2;
								// xy: TextureUV
								// zw: WorldNormal(yz)
								float4 Packed2 : TEXCOORD3;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldNormal
								// w: Specular
								half4 Packed1 : TEXCOORD2;
								// xyz: WorldPos
								// w: Gloss
								float4 Packed2 : TEXCOORD3;
								float2 TextureUV : TEXCOORD4;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed1 : TEXCOORD2;
								// xyz: WorldPos
								// w: Metallic
								float4 Packed2 : TEXCOORD3;
								float2 TextureUV : TEXCOORD4;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldNormal
								// w: Smoothness
								half4 Packed1 : TEXCOORD2;
								// xyz: WorldPos
								// w: SpecularColor(x)
								float4 Packed2 : TEXCOORD3;
								// xy: TextureUV
								// zw: SpecularColor(yz)
								float4 Packed3 : TEXCOORD4;
							#endif
						#else
							float2 TextureUV : TEXCOORD2;
						#endif
					#else
						#if defined(NOVA_LIT)
							// xyz: WorldNormal
							// w: ScaleParam
							half4 Packed0 : TEXCOORD1;
							#if defined(NOVA_LAMBERT_LIGHTING)
								// xyz: WorldPos
								// w: BiasParam
								float4 Packed1 : TEXCOORD2;
								float2 TextureUV : TEXCOORD3;
							#elif defined(NOVA_BLINNPHONG_LIGHTING)
								// xyz: WorldPos
								// w: BiasParam
								float4 Packed1 : TEXCOORD2;
								// xy: TextureUV
								// z: Specular
								// w: Gloss
								float4 Packed2 : TEXCOORD3;
							#elif defined(NOVA_STANDARD_LIGHTING)
								// xyz: WorldPos
								// w: BiasParam
								float4 Packed1 : TEXCOORD2;
								// xy: TextureUV
								// z: Smoothness
								// w: Metallic
								float4 Packed2 : TEXCOORD3;
							#elif defined(NOVA_STANDARDSPECULAR_LIGHTING)
								// xyz: WorldPos
								// w: BiasParam
								float4 Packed1 : TEXCOORD2;
								// xy: TextureUV
								// z: Smoothness
								float3 Packed2 : TEXCOORD3;
								fixed3 SpecularColor : TEXCOORD4;
							#endif
						#else
							// xy: TextureUV
							// z: ScaleParam
							// w: BiasParam
							float4 Packed0 : TEXCOORD1;
						#endif
					#endif
				#endif
			#endif
		#endif
	#endif
	NOVA_LIT_V2F_END
};
////////////////// END GENERATED //////////////////

#include "../NovaPostV2F.cginc"

#endif