#include <windows.h>
#include <string.h>
#include <unknwn.h>

#ifndef VidgrabDecl
#define VidgrabDecl

//#region DeclareEnumeratedTypesH
   enum class TAero
   {
   ae_Default = 0,
   ae_AutoBestRenderingQuality = 1,
   ae_ForceOnWhenStartingVideo = 2,
   ae_ForceOffWhenStartingVideo = 3,
   ae_ForceOnImmediately = 4,
   ae_ForceOffImmediately = 5
   };
   
   enum class TApplicationPriority
   {
   ap_default = 0,
   ap_idle = 1,
   ap_normal = 2,
   ap_high = 3,
   ap_realtime = 4
   };
   
   enum class TASFDeinterlaceMode
   {
   adm_NotInterlaced = 0,
   adm_DeinterlaceNormal = 1,
   adm_DeinterlaceHalfSize = 2,
   adm_DeinterlaceHalfSizeDoubleRate = 3,
   adm_DeinterlaceInverseTelecine = 4,
   adm_DeinterlaceVerticalHalfSizeDoubleRate = 5
   };
   
   enum class TASFProfileVersion
   {
   apv_ProfileVersion_8 = 0,
   apv_ProfileVersion_9 = 1
   };
   
   enum class TAspectRatio
   {
   ar_Box = 0,
   ar_NoResize = 1,
   ar_Stretch = 2,
   ar_PanScan = 3
   };
   
   enum class TAudioChannelRenderMode
   {
   acrm_Normal = 0,
   acrm_RenderLeft = 1,
   acrm_RenderRight = 2,
   acrm_MuteLeft = 3,
   acrm_MuteRight = 4,
   acrm_Mute_All = 5,
   acrm_MixLeftAndRight = 6,
   acrm_PassThru = 7
   };
   
   enum class TAudioFormat
   {
   af_default = 0,
   af_8000_8b_1ch = 1,
   af_8000_8b_2ch = 2,
   af_8000_16b_1ch = 3,
   af_8000_16b_2ch = 4,
   af_11025_8b_1ch = 5,
   af_11025_8b_2ch = 6,
   af_11025_16b_1ch = 7,
   af_11025_16b_2ch = 8,
   af_16000_8b_1ch = 9,
   af_16000_8b_2ch = 10,
   af_16000_16b_1ch = 11,
   af_16000_16b_2ch = 12,
   af_22050_8b_1ch = 13,
   af_22050_8b_2ch = 14,
   af_22050_16b_1ch = 15,
   af_22050_16b_2ch = 16,
   af_32000_8b_1ch = 17,
   af_32000_8b_2ch = 18,
   af_32000_16b_1ch = 19,
   af_32000_16b_2ch = 20,
   af_44100_8b_1ch = 21,
   af_44100_8b_2ch = 22,
   af_44100_16b_1ch = 23,
   af_44100_16b_2ch = 24,
   af_48000_8b_1ch = 25,
   af_48000_8b_2ch = 26,
   af_48000_16b_1ch = 27,
   af_48000_16b_2ch = 28
   };
   
   enum class TAudioPCMFormat
   {
   PCM_U8 = 0,
   PCM_S16 = 1,
   PCM_S32 = 2,
   PCM_FLT = 3,
   PCM_DBL = 4
   };
   
   enum class TAudioSource
   {
   as_Default = 0,
   as_UseExternalAudio = 1,
   as_UseMixAudioSample = 2,
   as_SpeakerOutput = 3,
   as_DefaultWithSpeakerRecording = 4,
   as_Silent = 5
   };
   
   enum class TAuthenticationType
   {
   at_PublishingPoint = 0,
   at_IPCamera = 1,
   at_StreamingUrl = 2
   };
   
   enum class TAutoFileName
   {
   fn_Sequential = 0,
   fn_DateTime = 1,
   fn_Counter = 2,
   fn_Modulo = 3,
   fn_GUID = 4
   };
   
   enum class TAVIInfoType
   {
   av_Duration = 0,
   av_FrameCount = 1,
   av_VideoWidth = 2,
   av_VideoHeight = 3,
   av_VideoFrameRateFps = 4,
   av_VideoCodec = 5,
   av_AudioCodec = 6,
   av_AvgBitRate = 7,
   av_AudioChannels = 8,
   av_AudioSamplesPerSec = 9,
   av_AudioBitsPerSample = 10,
   av_FileSizeInKB = 11,
   av_AudioStreams = 12
   };
   
   enum class TAVIMuxConfig
   {
   avmx_SetInterleavingMode = 0,
   avmx_SetInterleave = 1,
   avmx_SetPreroll = 2
   };
   
   enum class TBorderStyle
   {
   bsNone = 0,
   bsSingle = 1
   };
   
   enum class TCameraControl
   {
   cc_Pan = 0,
   cc_Tilt = 1,
   cc_Roll = 2,
   cc_Zoom = 3,
   cc_Exposure = 4,
   cc_Iris = 5,
   cc_Focus = 6
   };
   
   enum class TCardinalDirection
   {
   cd_North = 0,
   cd_NorthEast = 1,
   cd_East = 2,
   cd_SouthEast = 3,
   cd_South = 4,
   cd_SouthWest = 5,
   cd_West = 6,
   cd_NorthWest = 7,
   cd_Center = 8
   };
   
   enum class TCompressionMode
   {
   cm_NoCompression = 0,
   cm_CompressOnTheFly = 1,
   cm_CompressAfterRecording = 2
   };
   
   enum class TCompressionType
   {
   ct_Video = 0,
   ct_Audio = 1,
   ct_AudioVideo = 2
   };
   
   enum class TCurrentState
   {
   cs_Down = 0,
   cs_Preview = 1,
   cs_Recording = 2,
   cs_Playback = 3,
   cs_Reencoding = 4
   };
   
   enum class TCursors
   {
   cr_Default = 0,
   cr_None = 1,
   cr_Arrow = 2,
   cr_cross = 3,
   cr_IBeam = 4,
   cr_Size = 5,
   cr_SizeNESW = 6,
   cr_SizeNS = 7,
   cr_SizeNWSE = 8,
   cr_SizeWE = 9,
   cr_UpArrow = 10,
   cr_HourGlass = 11,
   cr_Drag = 12,
   cr_NoDrop = 13,
   cr_HSplit = 14,
   cr_VSplit = 15,
   cr_MultiDrag = 16,
   cr_SQLWait = 17,
   cr_No = 18,
   cr_AppStart = 19,
   cr_Help = 20,
   cr_HandPoint = 21,
   cr_SizeAll = 22
   };
   
   enum class TDialog
   {
   dlg_VideoDevice = 0,
   dlg_VideoCompressor = 1,
   dlg_AudioCompressor = 2,
   dlg_StreamConfig = 3,
   dlg_VfwFormat = 4,
   dlg_VfwSource = 5,
   dlg_vfwDisplay = 6,
   dlg_VideoCrossbar = 7,
   dlg_AudioCrossbar = 8,
   dlg_TVTuner = 9,
   dlg_TVAudio = 10,
   dlg_AudioDevice = 11,
   dlg_NetShowConfig = 12,
   dlg_DScaler = 13,
   dlg_FFDShowVideo = 14,
   dlg_FFDShowAudio = 15,
   dlg_Multiplexer = 16,
   dlg_None = 17
   };
   
   enum class TDragAction
   {
   dsDragEnter = 0,
   dsDragLeave = 1,
   dsDragMove = 2
   };
   
   enum class TDVCommand
   {
   dv_Play = 0,
   dv_Stop = 1,
   dv_Freeze = 2,
   dv_Thaw = 3,
   dv_Ff = 4,
   dv_Rew = 5,
   dv_Record = 6,
   dv_RecordFreeze = 7,
   dv_RecordStrobe = 8,
   dv_StepFwd = 9,
   dv_StepRev = 10,
   dv_ModeShuttle = 11,
   dv_PlayFastestFwd = 12,
   dv_PlaySlowestFwd = 13,
   dv_PlayFastestRev = 14,
   dv_PlaySlowestRev = 15
   };
   
   enum class TDVDInfoType
   {
   dvd_NumberOfVolumes = 0,
   dvd_TotalDuration = 1,
   dvd_NumberOfTitles = 2,
   dvd_TitleDuration = 3,
   dvd_TitleFrameRate = 4,
   dvd_SourceResolutionX = 5,
   dvd_SourceResolutionY = 6,
   dvd_TitleFrameCount = 7
   };
   
   enum class TDVSize
   {
   dv_Full = 0,
   dv_Half = 1,
   dv_Quarter = 2,
   dv_DC = 3
   };
   
   enum class TDVVideoFormat
   {
   dvf_Default = 0,
   dvf_DVSD = 1,
   dvf_DVHD = 2,
   dvf_DVSL = 3
   };
   
   enum class TDVVideoStandard
   {
   dvs_Default = 0,
   dvs_PAL = 1,
   dvs_NTSC = 2
   };
   
   enum class TEncoder_int
   {
   Enc_IsActive_bool = 0,
   Enc_Bytes_Written_kb_readonly = 1,
   Enc_Audio_Enabled_bool = 2,
   Enc_Audio_Channels = 3,
   Enc_Audio_SamplesPerSec = 4,
   Enc_Audio_BitsPerSample = 5,
   Enc_Audio_BitRate_kb = 6,
   Enc_Audio_PCM_Format = 7,
   Enc_Video_Enabled_bool = 8,
   Enc_Video_Width = 9,
   Enc_Video_Height = 10,
   Enc_Video_BitCount = 11,
   Enc_Video_AvgTimePerFrame = 12,
   Enc_Video_BitRate_kb = 13,
   Enc_Video_rc_MinBitRate_kb = 14,
   Enc_Video_rc_MaxBitRate_kb = 15,
   Enc_Video_rc_BufferSize_kb = 16,
   Enc_Video_IDR_Interval = 17,
   Enc_Video_Max_BFrames = 18,
   Enc_Video_FrameRate_x100 = 19,
   Enc_IsRealTime_bool = 20,
   Enc_IsScreenRecording_bool = 21,
   Enc_Video_Thread_Count = 22,
   Enc_Video_GPU_Encoder = 23,
   Enc_Video_GPU_EncoderDevice = 24
   };
   
   enum class TEncoder_str
   {
   Enc_OutputURL = 0,
   Enc_Video_Codec = 1,
   Enc_Audio_Codec = 2,
   Enc_Extra_Parameters = 3
   };
   
   enum class TFileSort
   {
   fs_TimeAsc = 0,
   fs_TimeDesc = 1,
   fs_NameAsc = 2,
   fs_NameDesc = 3
   };
   
   enum class TFiltersSet
   {
   fs_Datastead = 0
   };
   
   enum class TFormatType
   {
   ft_VideoInfo = 0,
   ft_VideoInfo2 = 1,
   ft_DvInfo = 2,
   ft_Mpeg1Video = 3,
   ft_Mpeg2Video = 4,
   ft_Mpeg1Stream = 5,
   ft_Mpeg2Stream = 6,
   ft_MpegStreamType = 7,
   ft_MpegCustom = 8,
   ft_WaveFormatEx = 9,
   ft_Mpeg1Audio = 10,
   ft_Mpeg2Audio = 11,
   ft_Mpeg3Audio = 12,
   ft_OGG = 13,
   ft_GSM = 14,
   ft_Unknown = 15
   };
   
   enum class TFrameBitmapInfoType
   {
   fb_VideoWidth = 0,
   fb_VideoHeight = 1,
   fb_BitmapSize = 2,
   fb_BitmapStride = 3,
   fb_BitsPerPixel = 4
   };
   
   enum class TFrameCaptureDest
   {
   fc_TBitmap = 0,
   fc_BmpFile = 1,
   fc_JpegFile = 2,
   fc_Clipboard = 3,
   fc_TiffFile = 4,
   fc_PngFile = 5
   };
   
   enum class TFrameGrabber
   {
   fg_BothStreams = 0,
   fg_PreviewStream = 1,
   fg_CaptureStream = 2,
   fg_Disabled = 3
   };
   
   enum class TFrameGrabberRGBFormat
   {
   fgf_Default = 0,
   fgf_RGB32 = 1,
   fgf_RGB24 = 2,
   fgf_RGB565 = 3,
   fgf_RGB555 = 4,
   fgf_RGB8 = 5
   };
   
   enum class TFrameInfoId
   {
   fi_FrameNumber = 0,
   fi_DroppedFrameCount = 1,
   fi_SampleTime_Hour = 2,
   fi_SampleTime_Min = 3,
   fi_SampleTime_Sec = 4,
   fi_SampleTime_Hs = 5,
   fi_SampleTime_TotalMin = 6,
   fi_DVTimeCode_IsAvailable = 7,
   fi_DVTimeCode_Hour = 8,
   fi_DVTimeCode_Min = 9,
   fi_DVTimeCode_Sec = 10,
   fi_DVTimeCode_Ff = 11,
   fi_DVTimeCode_TrackNumber = 12,
   fi_DVDateTime_IsAvailable = 13,
   fi_DVDateTime_Year = 14,
   fi_DVDateTime_Month = 15,
   fi_DVDateTime_Day = 16,
   fi_DVDateTime_Hour = 17,
   fi_DVDateTime_Min = 18,
   fi_DVDateTime_Sec = 19,
   fi_NTPFrameTime = 20,
   fi_First_NTP_time_Recorded = 21
   };
   
   enum class TFrameInfoStringId
   {
   fis_DVTimeCode = 0,
   fis_DVDateTime = 1,
   fis_TimeCode = 2,
   fis_FrameTime = 3,
   fis_FrameNumber = 4,
   fis_FullInfo = 5,
   fis_NTPFrameTime = 6
   };
   
   enum class TGPUEncoder
   {
   Enc_GPU_None = 0,
   Enc_GPU_Auto = 1,
   Enc_GPU_Intel_QSV = 2,
   Enc_GPU_NVidia_NVENC = 3,
   Enc_GPU_AMD_AMF = 4
   };
   
   enum class TGraphState
   {
   gs_Stopped = 0,
   gs_Paused = 1,
   gs_Running = 2
   };
   
   enum class THeaderAttribute
   {
   ha_Title = 0,
   ha_Description = 1,
   ha_Author = 2,
   ha_Copyright = 3,
   ha_AlbumArtist = 4,
   ha_AlbumTitle = 5,
   ha_Composer = 6,
   ha_ContentDistributor = 7,
   ha_Director = 8,
   ha_EncodingTime = 9,
   ha_Genre = 10,
   ha_Language = 11,
   ha_ParentalRating = 12,
   ha_Producer = 13,
   ha_Provider = 14,
   ha_ToolName = 15,
   ha_ToolVersion = 16,
   ha_Writer = 17,
   ha_IARL = 18,
   ha_ICMS = 19,
   ha_ICMT = 20,
   ha_ICRD = 21,
   ha_ICRP = 22,
   ha_IDIM = 23,
   ha_IDPI = 24,
   ha_IENG = 25,
   ha_IGNR = 26,
   ha_IKEY = 27,
   ha_ILGT = 28,
   ha_IMED = 29,
   ha_IPLT = 30,
   ha_IPRD = 31,
   ha_ISFT = 32,
   ha_ISHP = 33,
   ha_ISRC = 34,
   ha_ISRF = 35,
   ha_ITCH = 36
   };
   
   enum class THwAccel
   {
   hw_None = 0,
   hw_Cuda = 1,
   hw_QuickSync = 2,
   hw_Dxva2 = 3,
   hw_d3d11 = 4
   };
   
   enum class TIPCameraSetting
   {
   ips_ConnectionTimeout = 0,
   ips_ReceiveTimeout = 1
   };
   
   enum class TJPEGPerformance
   {
   jpBestQuality = 0,
   jpBestSpeed = 1
   };
   
   enum class TLogoLayout
   {
   lg_Centered = 0,
   lg_Stretched = 1,
   lg_Repeated = 2,
   lg_TopLeft = 3,
   lg_TopRight = 4,
   lg_BottomLeft = 5,
   lg_BottomRight = 6,
   lg_Boxed = 7
   };
   
   enum class TLogType
   {
   e_add_filter = 0,
   e_add_source_filter = 1,
   e_audio_compressor_not_suitable = 2,
   e_bind_moniker_to_filter = 3,
   e_compressor_possibly_not_suitable = 4,
   e_create_instance = 5,
   e_ddraw_caps_not_suitable = 6,
   e_device_in_use_in_another_graph = 7,
   e_disk_full = 8,
   e_failed = 9,
   e_failed_to_allocate_recording_file = 10,
   e_failed_to_bind_codec = 11,
   e_failed_to_connect_crossbar_pin = 12,
   e_failed_to_connect_to_server = 13,
   e_failed_to_create_directory = 14,
   e_failed_to_create_file = 15,
   e_failed_to_create_temp = 16,
   e_failed_to_bind_frame_grabber = 17,
   e_failed_to_load_ASF_profile = 18,
   e_failed_to_load_ASF_profile_custom_file = 19,
   e_failed_to_load_set_of_bitmaps = 20,
   e_failed_to_set_image_overlay = 21,
   e_failed_to_set_logo = 22,
   e_failed_to_play_backwards = 23,
   e_failed_to_render_file = 24,
   e_failed_to_renew_recording_file = 25,
   e_failed_to_set_player_speed_ratio_with_audio = 26,
   e_failed_to_setup_network_streaming = 27,
   e_failed_to_start_preview = 28,
   e_failed_to_start_recording = 29,
   e_file_in_use = 30,
   e_file_name_not_specified = 31,
   e_file_not_found = 32,
   e_get_audio_format = 33,
   e_get_interface = 34,
   e_get_video_format = 35,
   e_graph_error = 36,
   e_graph_cant_run = 37,
   e_graph_must_be_restarted = 38,
   e_hw_deinterlace_not_supported = 39,
   e_incompatible_options = 40,
   e_index_out_of_range = 41,
   e_invalid_directory = 42,
   e_library_not_found = 43,
   e_load_filter = 44,
   e_no_audio_In_device = 45,
   e_no_device_available = 46,
   e_no_dialog = 47,
   e_no_stream_control = 48,
   e_no_tv_tuner = 49,
   e_no_device_selected = 50,
   e_no_video_input_device = 51,
   e_not_allowed_during_network_streaming = 52,
   e_not_allowed_with_streaming_URL = 53,
   e_not_assigned = 54,
   e_not_multiplexed_master = 55,
   e_not_previewing = 56,
   e_not_recording = 57,
   e_not_reencoding = 58,
   e_not_streaming = 59,
   e_out_of_memory = 60,
   e_pause_resume_disabled = 61,
   e_pin_not_found = 62,
   e_interface_not_assigned = 63,
   e_query_config_avi_mux = 64,
   e_reencoding = 65,
   e_recording_cannot_pause = 66,
   e_render_audio_stream = 67,
   e_render_video_stream = 68,
   e_must_restart_master = 69,
   e_recording_on_motion_failed = 70,
   e_sendtodv_device_index_out_of_bound = 71,
   e_sendtodv_deviceindex_and_videodevice_have_same_value = 72,
   e_sendtodv_failed_to_bind_dv_device = 73,
   e_set_filter_graph = 74,
   e_set_interleaving_mode = 75,
   e_set_master_stream = 76,
   e_set_output_compatibility_index = 77,
   e_set_output_file_name = 78,
   e_set_format = 79,
   e_start_preview_first = 80,
   e_stop_player_first = 81,
   e_stop_preview_first = 82,
   e_stop_recording_first = 83,
   e_stop_reencoding_first = 84,
   e_storage_path_read_only = 85,
   e_streaming_type_not_specified = 86,
   e_third_party_filter_already_inserted = 87,
   e_third_party_filter_error = 88,
   e_trace_log = 89,
   e_tv_command_not_allowed_during_tv_tuning = 90,
   e_tuner_input_not_selected = 91,
   e_TVideoGrabber_Filter_obsolete = 92,
   e_value_out_of_range = 93,
   e_video_compressor_not_suitable = 94,
   e_window_transparency_failed = 95,
   e_invalid_size = 96,
   e_invalid_window_handle = 97,
   e_tuner_mode_not_supported = 98,
   e_publishing_point_connection_failed = 99,
   e_speaker_control_disabled = 100,
   i_audio_device_associated_to_video_device = 101,
   i_begin_discovering_device = 102,
   i_binding_device_or_compressor = 103,
   i_discovering_device = 104,
   i_end_discovering_device = 105,
   i_preallocated_file_size_large_enough = 106,
   i_preallocated_file_size_changed = 107,
   i_preallocated_file_not_suitable = 108,
   i_streaming_to_publishing_point = 109,
   i_third_party_filter_inserted = 110,
   i_using_ASF_Profile = 111,
   i_recording_videosubtype = 112,
   i_ismpegstream = 113,
   i_new_recording_filename = 114,
   i_using_property_group = 115,
   i_streaming_client_connected = 116,
   i_streaming_client_disconnected = 117,
   i_refreshing_preview = 118,
   i_recording_on_motion = 119,
   i_window_found = 120,
   i_limiting_preview = 121,
   i_codec_recommended = 122,
   i_tuner_mode = 123,
   i_DV_date_time_discontinuity = 124,
   w_cannot_connect_thirdparty_filter = 125,
   w_cannot_connect_thirdparty_renderer = 126,
   w_cannot_instantiate_thirdparty_filter = 127,
   w_cannot_route_crossbar = 128,
   w_cannot_use_color_key = 129,
   w_command_delayed = 130,
   w_does_not_apply_to_dv = 131,
   w_find_audio_device = 132,
   w_filter_does_not_save_properties = 133,
   w_frame_grabber_requires_CPU = 134,
   w_hold_recording = 135,
   w_information = 136,
   w_not_playing = 137,
   w_player_audio_should_be_disabled = 138,
   w_recording_cancelled_by_user = 139,
   w_can_pause_and_ASF_incompatible = 140,
   w_set_audio_format = 141,
   w_storage_path_on_network = 142,
   w_tv_tuner = 143,
   w_using_nearest_video_size = 144,
   w_divx_codec_not_installed = 145,
   w_codec_does_not_support_debugger = 146,
   w_divx_codec_profile = 147,
   w_device_partially_supported = 148,
   w_excessive_grid_size = 149,
   w_grid_too_large_for_dialog = 150,
   w_operation_may_lock = 151,
   w_audio_streaming_needs_audiorecording_property_enabled = 152,
   w_network_streaming_disabled = 153,
   w_server_lost_next_retry = 154,
   w_overlay_mixer_not_available = 155,
   w_network_streaming_change_requires_application_to_be_restarted = 156,
   w_standard_renderer_recommended = 157,
   w_window_transparency_and_recording_not_recommended = 158,
   w_clip_not_seekable = 159,
   w_only_WMV_recording_during_network_streaming = 160,
   w_check_analog_video_standard = 161,
   w_recording_timer_set = 162,
   w_stream_time_beyong_script_time = 163,
   w_generate_new_file = 164,
   w_hires_timer_not_available = 165,
   w_applies_to_the_current_recording_method = 166,
   i_leaving_full_screen_mode = 167,
   i_stream_info = 168,
   i_async_url_connection_in_progress = 169,
   i_async_url_connection_cancelled = 170,
   e_obsolete = 171,
   i_codec_info = 172,
   i_preview_started = 173,
   i_recording_started = 174,
   i_reencoding_started = 175,
   i_recording_completed = 176,
   i_reencoding_completed = 177,
   i_player_opened = 178,
   i_inactive = 179,
   i_using_stream_index = 180,
   e_failed_to_start_reencoding = 181,
   e_recording_failed = 182,
   e_failed_to_open_player = 183,
   i_mpe_terminatedsuccess = 184,
   e_mpe_terminatederror = 185,
   i_mpe_logcallback = 186,
   i_duration_updated = 187,
   e_ptz_command_failed = 188,
   i_ptz_command_result = 189,
   w_potential_out_of_range = 190,
   i_recording_paused = 191,
   i_configuration_info = 192,
   w_virtualmachine = 193,
   i_recording_resumed = 194,
   e_failed_to_write_sample = 195,
   e_exception = 196,
   e_failed_to_open_url = 197
   };
   
   enum class TMiscDeviceControl
   {
   mdc_GPIO = 0,
   mdc_VPD = 1,
   mdc_VPD_Data = 2
   };
   
   enum class TMouseButton
   {
   mbLeft = 0,
   mbRight = 1,
   mbMiddle = 2
   };
   
   enum class TMPEGProgramSetting
   {
   mps_Program_Number = 0,
   mps_Program_PCR_PID = 1,
   mps_VideoStream_PID = 2,
   mps_AudioStream_PID = 3,
   mps_VideoStream_Type = 4,
   mps_AudioStream_Type = 5,
   mps_VideoFormat_Width = 6,
   mps_VideoFormat_Height = 7,
   mps_VideoAspectRatio_X = 8,
   mps_VideoAspectRatio_Y = 9,
   mps_ReceiveTimeoutInSeconds = 10
   };
   
   enum class TMpegStreamType
   {
   mpst_Default = 0,
   mpst_Program = 1,
   mpst_Program_DVD = 2,
   mpst_Program_DVD_MC = 3,
   mpst_Program_SVCD = 4,
   mpst_MPEG1 = 5,
   mpst_MPEG1_VCD = 6
   };
   
   enum class TMultiplexedRole
   {
   mr_NotMultiplexed = 0,
   mr_MultiplexedMosaic4 = 1,
   mr_MultiplexedMosaic16 = 2,
   mr_MultiplexedMaster = 3,
   mr_MultiplexedSlave = 4
   };
   
   enum class TMultipurposeEncoderInstance
   {
   mpe_Recording = 0,
   mpe_Streaming = 1,
   mpe_Reencoding = 2,
   mpe_Edit = 3
   };
   
   enum class TNDIBandwidthType
   {
   nbt_MetadataOnly = 0,
   nbt_AudioOnly = 1,
   nbt_LowestBandwidth = 2,
   nbt_HighestBandwidth = 3
   };
   
   enum class TNetworkStreaming
   {
   ns_Disabled = 0,
   ns_ASFDirectNetworkStreaming = 1,
   ns_ASFStreamingToPublishingPoint = 2,
   ns_NDI = 3
   };
   
   enum class TNetworkStreamingType
   {
   nst_AudioVideoStreaming = 0,
   nst_VideoStreaming = 1,
   nst_AudioStreaming = 2
   };
   
   enum class TNotificationMethod
   {
   nm_Timer = 0,
   nm_Thread = 1
   };
   
   enum class TONVIFDeviceInfo
   {
   onv_Manufacturer = 0,
   onv_Model = 1,
   onv_HardwareId = 2,
   onv_SerialNumber = 3,
   onv_FirmwareVersion = 4,
   onv_PTZInfo = 5,
   onv_PTZPresets = 6,
   onv_MacAddress = 7,
   onv_AuxiliaryCommands = 8,
   onv_XMLReplay = 9,
   onv_XMLInfo = 10
   };
   
   enum class TPlayerState
   {
   ps_Closed = 0,
   ps_Stopped = 1,
   ps_Paused = 2,
   ps_Playing = 3,
   ps_PlayingBackward = 4,
   ps_FastForwarding = 5,
   ps_FastRewinding = 6,
   ps_Downloading = 7,
   ps_DownloadCompleted = 8,
   ps_DownloadCancelled = 9,
   ps_Opened = 10
   };
   
   enum class TPlaylist
   {
   pl_Add = 0,
   pl_Remove = 1,
   pl_Clear = 2,
   pl_Loop = 3,
   pl_NoLoop = 4,
   pl_Play = 5,
   pl_Stop = 6,
   pl_Next = 7,
   pl_Previous = 8,
   pl_SortAlpha = 9,
   pl_SortRevAlpha = 10,
   pl_Random = 11,
   pl_Sequential = 12,
   pl_SpecifyPositions = 13,
   pl_Transition = 14
   };
   
   enum class TPointGreyConfig
   {
   pgr_SetRegister = 0,
   pgr_GetRegister = 1,
   pgr_SetBufferSize = 2,
   pgr_GetBufferSize = 3,
   pgr_SetFormat = 4,
   pgr_GetFormat = 5
   };
   
   enum class TRawSampleCaptureLocation
   {
   rl_SourceFormat = 0,
   rl_AfterCompression = 1
   };
   
   enum class TRecordingMethod
   {
   rm_AVI = 0,
   rm_ASF = 1,
   rm_SendToDV = 2,
   rm_MKV = 3,
   rm_FLV = 4,
   rm_MP4 = 5,
   rm_WebM = 6,
   rm_MPG = 7,
   rm_Multiplexer = 8,
   rm_MOV = 9,
   rm_TS = 10,
   rm_H264 = 11,
   rm_MP3 = 12,
   rm_WMA = 13,
   rm_WAV = 14
   };
   
   enum class TRecordingSize
   {
   rs_Default = 0,
   rs_HalfSize = 1,
   rs_QuarterSize = 2
   };
   
   enum class TRecordingTimer
   {
   rt_Disabled = 0,
   rt_RecordToNewFile = 1,
   rt_StopRecording = 2,
   rt_StartRecording = 3,
   rt_PauseRecording = 4,
   rt_FrameCapture = 5
   };
   
   enum class TRGBSelector
   {
   rs_Red = 0,
   rs_Green = 1,
   rs_Blue = 2
   };
   
   enum class TStoragePathMode
   {
   spm_AutoFileNameOnly = 0,
   spm_AnyFile = 1
   };
   
   enum class TStreamType
   {
   st_Video = 0,
   st_Audio = 1
   };
   
   enum class TSynchronizationRole
   {
   sr_Master = 0,
   sr_Slave = 1,
   sr_Mixer = 2
   };
   
   enum class TSyncPreview
   {
   sp_Auto = 0,
   sp_Disabled = 1,
   sp_Enabled = 2
   };
   
   enum class TTextOrientation
   {
   to_Horizontal = 0,
   to_Vertical = 1,
   to_VerticalInverted = 2
   };
   
   enum class TTextOverlayAlign
   {
   tf_Left = 0,
   tf_Center = 1,
   tf_Right = 2
   };
   
   enum class TTextOverlayGradientMode
   {
   gm_Disabled = 0,
   gm_Horizontal = 1,
   gm_Vertical = 2,
   gm_ForwardDiagonal = 3,
   gm_BackwardDiagonal = 4
   };
   
   enum class TThirdPartyFilterList
   {
   tpf_VideoSource = 0,
   tpf_VideoPreview = 1,
   tpf_VideoRecording = 2,
   tpf_AudioSource = 3,
   tpf_AudioRendering = 4,
   tpf_AudioRecording = 5,
   tpf_VideoRendering = 6,
   tpf_VideoRenderer = 7,
   tpf_AudioRenderer = 8,
   tpf_ThirdPartyVideoSource = 9,
   tpf_ThirdPartyAudioSource = 10,
   tpf_AddToGraph = 11
   };
   
   enum class TThreadPriority
   {
   tpIdle = 0,
   tpLowest = 1,
   tpLower = 2,
   tpNormal = 3,
   tpHigher = 4,
   tpHighest = 5,
   tpTimeCritical = 6
   };
   
   enum class TThreadSyncPoint
   {
   tsp_SyncPoint1 = 0,
   tsp_SyncPoint2 = 1,
   tsp_SetParent = 2,
   tsp_UnSetParent = 3
   };
   
   enum class TTrackbarAction
   {
   tba_MouseDown = 0,
   tba_MouseUp = 1,
   tba_KeyDown = 2,
   tba_KeyUp = 3
   };
   
   enum class TTriState
   {
   ts_Undefined = 0,
   ts_False = 1,
   ts_True = 2
   };
   
   enum class TTunerInputType
   {
   TunerInputCable = 0,
   TunerInputAntenna = 1
   };
   
   enum class TTunerMode
   {
   tm_TVTuner = 0,
   tm_FMRadioTuner = 1,
   tm_AMRadioTuner = 2,
   tm_DigitalSatelliteTuner = 3
   };
   
   enum class TTVChannelInfo
   {
   tci_Channel = 0,
   tci_DefaultVideoFrequency = 1,
   tci_OverriddenVideoFrequency = 2,
   tci_TunerVideoFrequency = 3,
   tci_TunerAudioFrequency = 4,
   tci_Locked = 5
   };
   
   enum class Tv360_Angle
   {
   v360_fov_Diagonal = 0,
   v360_fov_Horizontal = 1,
   v360_fov_Vertical = 2
   };
   
   enum class Tv360_InOut
   {
   v360_in = 0,
   v360_out = 1
   };
   
   enum class Tv360_Interpolation
   {
   ipl_Bilinear = 0,
   ipl_Nearest = 1,
   ipl_Lagrange9 = 2,
   ipl_Bicubic = 3,
   ipl_Lanczos = 4,
   ipl_Spline16 = 5,
   ipl_Gaussian = 6,
   ipl_Mitchell = 7
   };
   
   enum class TV360_MouseAction
   {
   ma_Disabled = 0,
   ma_MouseUp = 1,
   ma_MouseMove = 2
   };
   
   enum class Tv360_Projection
   {
   ipp_Equirectangular = 0,
   ipp_Cubemap_3_2 = 1,
   ipp_Cubemap_6_1 = 2,
   ipp_Equiangular = 3,
   ipp_Flat = 4,
   ipp_Dual_fisheye = 5,
   ipp_Barrel = 6,
   ipp_Cubemap_1_6 = 7,
   ipp_Stereographic = 8,
   ipp_Mercator = 9,
   ipp_Ball = 10,
   ipp_Hammer = 11,
   ipp_Sinusoidal = 12,
   ipp_Fisheye = 13,
   ipp_Pannini = 14,
   ipp_Cylindrical = 15,
   ipp_Perspective = 16,
   ipp_Tetrahedron = 17,
   ipp_Barrel_split = 18,
   ipp_Tspyramid = 19,
   ipp_Hequirectangular = 20,
   ipp_Equisolid = 21,
   ipp_Orthographic = 22,
   ipp_Octahedron = 23
   };
   
   enum class Tv360_StereoFormat
   {
   sf_2DMono = 0,
   sf_SideBySide = 1,
   sf_TopBottom = 2
   };
   
   enum class TVideoAlignment
   {
   oa_LeftTop = 0,
   oa_CenterTop = 1,
   oa_RightTop = 2,
   oa_LeftCenter = 3,
   oa_Center = 4,
   oa_RightCenter = 5,
   oa_LeftBottom = 6,
   oa_CenterBottom = 7,
   oa_RightBottom = 8
   };
   
   enum class TVideoControl
   {
   vc_FlipHorizontal = 0,
   vc_FlipVertical = 1,
   vc_ExternalTriggerEnable = 2,
   vc_Trigger = 3
   };
   
   enum class TVideoDeinterlacing
   {
   di_Disabled = 0,
   di_HalfSize = 1,
   di_FullSize = 2,
   di_DScaler = 3,
   di_AVISynth = 4,
   di_FFDShow = 5,
   di_ThirdPartyDeinterlacer = 6
   };
   
   enum class TVideoQuality
   {
   vq_Brightness = 0,
   vq_Contrast = 1,
   vq_Hue = 2,
   vq_Saturation = 3,
   vq_Sharpness = 4,
   vq_Gamma = 5,
   vq_ColorEnable = 6,
   vq_WhiteBalance = 7,
   vq_BacklightCompensation = 8,
   vq_Gain = 9
   };
   
   enum class TVideoRenderer
   {
   vr_AutoSelect = 0,
   vr_EVR = 1,
   vr_VMR9 = 2,
   vr_VMR7 = 3,
   vr_StandardRenderer = 4,
   vr_OverlayRenderer = 5,
   vr_RecordingPriority = 6,
   vr_None = 7,
   vr_madVR = 8
   };
   
   enum class TVideoRendererExternal
   {
   vre_None = 0,
   vre_Matrox_PRO = 1,
   vre_Decklink_SD = 2,
   vre_Decklink_Extreme = 3,
   vre_Pinnacle_MovieBoard = 4,
   vre_BlackMagic_Decklink = 5,
   vre_AJA = 6
   };
   
   enum class TVideoRendererPriority
   {
   vrp_Speed = 0,
   vrp_Quality = 1,
   vrp_Auto = 2
   };
   
   enum class TVideoRotation
   {
   rt_0_deg = 0,
   rt_90_deg = 1,
   rt_180_deg = 2,
   rt_270_deg = 3,
   rt_0_deg_mirror = 4,
   rt_90_deg_mirror = 5,
   rt_180_deg_mirror = 6,
   rt_270_deg_mirror = 7,
   rt_custom_angle = 8,
   rt_custom_angle_mirror = 9
   };
   
   enum class TVideoSource
   {
   vs_VideoCaptureDevice = 0,
   vs_ScreenRecording = 1,
   vs_VideoFileOrURL = 2,
   vs_JPEGsOrBitmaps = 3,
   vs_IPCamera = 4,
   vs_Mixer = 5,
   vs_VideoFromImages = 6,
   vs_ThirdPartyFilter = 7,
   vs_StreamInterface = 8
   };
   
   enum class TVideoWindowNotify
   {
   vwActive = 0,
   vwVisible = 1,
   vwAutoSize = 2,
   vwEmbedded = 3,
   vwEmbeddedFitParent = 4,
   vwDisplayParent = 5,
   vwColorKeyEnabled = 6,
   vwAlphaBlendEnabled = 7,
   vwFullScreen = 8,
   vwStayOnTop = 9,
   vwMouseMovesWindow = 10,
   vwVideoPortEnabled = 11,
   vwMonitor = 12,
   vwAspectRatio = 13,
   vwVideoWidth = 14,
   vwVideoHeight = 15,
   vwPanScanRatio = 16,
   vwColorKeyValue = 17,
   vwAlphaBlendValue = 18,
   vwLeft = 19,
   vwTop = 20,
   vwLocation = 21
   };
   
   enum class TVMR9ImageAdjustment
   {
   vmr9_Brightness = 0,
   vmr9_Contrast = 1,
   vmr9_Hue = 2,
   vmr9_Saturation = 3,
   vmr9_Alpha = 4
   };
   
   enum class TVuMeter
   {
   vu_Disabled = 0,
   vu_Analog = 1,
   vu_Bargraph = 2,
   vu_AnalogOverlay = 3,
   vu_BargraphOverlay = 4
   };
   
   enum class TVUMeterSetting
   {
   vu_Handle = 0,
   vu_WarningPercent = 1,
   vu_PeakPercent = 2,
   vu_BkgndColor = 3,
   vu_NormalColor = 4,
   vu_WarningColor = 5,
   vu_PeakColor = 6,
   vu_TickSize = 7,
   vu_TickInterval = 8,
   vu_NeedleThickness = 9,
   vu_OverlayLeft = 10,
   vu_OverlayTop = 11,
   vu_OverlayWidth = 12,
   vu_OverlayHeight = 13,
   vu_Transparent = 14,
   vu_FlipVert = 15,
   vu_FlipHorz = 16,
   vu_CustomPercentValue = 17,
   vu_LogarithmicScale = 18
   };
   
   enum class TWebcamStillCaptureButton
   {
   wb_Disabled = 0,
   wb_Enabled = 1
   };
   
//#endregion DeclareEnumeratedTypesH

   typedef struct TFrameInfo
   {
            __int64 frameTime;
            __int64 frameTime_TotalMin;
            __int64 frameTime_TotalSec;
            __int64 frameTime_TotalHs;
            __int64 framenumber;
            int droppedframecount;
            int frametime_hour;
            int frametime_min;
            int frametime_sec;
            int frametime_hs;
            int dvtimecode_isavailable;
            int dvtimecode_hour;
            int dvtimecode_min;
            int dvtimecode_sec;
            int dvtimecode_ff;
            int dvtimecode_tracknumber;
            int dvdatetime_isavailable;
            int dvdatetime_year;
            int dvdatetime_month;
            int dvdatetime_day;
            int dvdatetime_hour;
            int dvdatetime_min;
            int dvdatetime_sec;
            TCurrentState CurrentState;
            TGraphState GraphState;
            TPlayerState PlayerState;
            __int64 NTPFrameTime;
   } TFrameInfo;

   typedef struct TFrameBitmapInfo
   {
            int bitmapWidth;
            int bitmapHeight;
            int bitmapBitsPerPixel;
            int bitmapLineSize;
            int bitmapSize;
            int bitmapPlanes;
            HBITMAP bitmapHandle;
            byte *bitmapDataPtr;
            HDC bitmapDC;
            int CurrentXMouseLocation;
            int CurrentYMouseLocation;
            int LastXMouseDownLocation;
            int LastYMouseDownLocation;
            BOOL IsMouseDown;
            TMouseButton LastMouseButtonClicked;
			int Dummy1;
			HANDLE hSec;
            int reserved0;
   } TFrameBitmapInfo;

//#region DeclareCallbackTypeH
   typedef void CALLBACK TOnAudioBufferNegotiationCb  (void *Object, void *Sender, int  nChannels, int  nSamplesPerSec, int  BitsPerSample, int  *ProposedBufferSize);
   typedef void CALLBACK TOnAudioDeviceSelectedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnAudioPeakCb  (void *Object, void *Sender, double  Left_Percent, double  Left_DB, double  Right_Percent, double  Right_DB);
   typedef void CALLBACK TOnAuthenticationNeededCb  (void *Object, void *Sender, TAuthenticationType  AuthenticationType, const wchar_t *Realm, const wchar_t *Server, const wchar_t **Username, const wchar_t **Password);
   typedef void CALLBACK TOnAVIDurationUpdatedCb  (void *Object, void *Sender, const wchar_t *FileName, unsigned int  FrameCount, double  *FrameRate, __int64  *Duration);
   typedef void CALLBACK TOnBacktimedFramesCountReachedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnBitmapsLoadingProgressCb  (void *Object, void *Sender, int  Percent, __int64  Position, __int64  Duration, const wchar_t *Comment);
   typedef void CALLBACK TOnClickCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnClientConnectionCb  (void *Object, void *Sender, BOOL  Connected, const wchar_t *ClientInfo);
   typedef void CALLBACK TOnColorKeyChangeCb  (void *Object, void *Sender, int  ColorKey);
   typedef void CALLBACK TOnCopyPreallocDataCompletedCb  (void *Object, void *Sender, const wchar_t *SourceFile, const wchar_t *DestFile, BOOL  Success);
   typedef void CALLBACK TOnCopyPreallocDataProgressCb  (void *Object, void *Sender, int  Percent, __int64  Position, __int64  Duration);
   typedef void CALLBACK TOnCopyPreallocDataStartedCb  (void *Object, void *Sender, const wchar_t *SourceFile, const wchar_t *DestFile);
   typedef void CALLBACK TOnCreatePreallocFileCompletedCb  (void *Object, void *Sender, const wchar_t *FileName, BOOL  Success);
   typedef void CALLBACK TOnCreatePreallocFileProgressCb  (void *Object, void *Sender, int  Percent, __int64  Position, __int64  Duration);
   typedef void CALLBACK TOnCreatePreallocFileStartedCb  (void *Object, void *Sender, const wchar_t *FileName);
   typedef void CALLBACK TOnDblClickCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnDeviceArrivalOrRemovalCb  (void *Object, void *Sender, BOOL  IsDeviceArrival, BOOL  IsVideoDevice, const wchar_t *DeviceName, int  DeviceIndex);
   typedef void CALLBACK TOnDeviceLostCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnDeviceReconnectedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnDeviceReconnectingCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnDirectNetworkStreamingHostUrlCb  (void *Object, void *Sender, const wchar_t *HostUrl, const wchar_t *HostName, int  HostPort);
   typedef void CALLBACK TOnDiskFullCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnDragDropCb  (void *Object, void *Sender, void *Source, int  X, int  Y);
   typedef void CALLBACK TOnDragDropFilesCb  (void *Object, void *Sender, int  FileCount, const wchar_t *FirstFile, const wchar_t *FilesList);
   typedef void CALLBACK TOnDragOverCb  (void *Object, void *Sender, void *Source, int  X, int  Y, TDragAction  State, BOOL  *Accept);
   typedef void CALLBACK TOnDVCommandCompletedCb  (void *Object, void *Sender, int  NewStateValue, const wchar_t *NewStateLabel);
   typedef void CALLBACK TOnDVDiscontinuityCb  (void *Object, void *Sender, BOOL  *DeliverNewFrame);
   typedef void CALLBACK TOnEnumerateWindowsCb  (void *Object, void *Sender, HWND  WindowHandle, const wchar_t *WindowName, const wchar_t *WindowClass);
   typedef void CALLBACK TOnFilterSelectedCb  (void *Object, void *Sender, const wchar_t *FilterName, BOOL  *RejectFilter);
   typedef void CALLBACK TOnFirstFrameReceivedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnFrameBitmapCb  (void *Object, void *Sender, TFrameInfo *FrameInfo, TFrameBitmapInfo *BitmapInfo);
   typedef void CALLBACK TOnFrameCaptureCompletedCb  (void *Object, void *Sender, HBITMAP  FrameBitmapHandle, int  BitmapWidth, int  BitmapHeight, unsigned int  FrameNumber, __int64  FrameTime, TFrameCaptureDest  DestType, const wchar_t *FileName, BOOL  Success, int  FrameId);
   typedef void CALLBACK TOnFrameOverlayUsingDCCb  (void *Object, void *Sender, HDC  Dc, unsigned int  FrameNumber, __int64  FrameTime, int  FrameId);
   typedef void CALLBACK TOnFrameOverlayUsingDIBCb  (void *Object, void *Sender, HBITMAP  FrameBitmapHandle, unsigned int  FrameNumber, __int64  FrameTime, int  FrameId);
   typedef void CALLBACK TOnFrameProgressCb  (void *Object, void *Sender, unsigned int  FrameNumber, __int64  FrameTime, int  FrameId);
   typedef void CALLBACK TOnFrameProgress2Cb  (void *Object, void *Sender, TFrameInfo *FrameInfo);
   typedef void CALLBACK TOnGraphBuiltCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnInactiveCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnKeyPressCb  (void *Object, void *Sender, int  VideoWindow, wchar_t  *Key, int  PhysicalKey, int  ShiftState);
   typedef void CALLBACK TOnLastCommandCompletedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnLeavingFullScreenCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnLogCb  (void *Object, void *Sender, TLogType  LogType, const wchar_t *Severity, const wchar_t *InfoMsg);
   typedef void CALLBACK TOnMotionDetectedCb  (void *Object, void *Sender, double  GlobalMotionRatio, int  MaxMotionCellX, int  MaxMotionCellY, HBITMAP  FrameBitmap, unsigned int  FrameNumber, __int64  FrameTime, int  FrameId, BOOL  *CaptureFrame);
   typedef void CALLBACK TOnMotionNotDetectedCb  (void *Object, void *Sender, HBITMAP  FrameBitmap, unsigned int  FrameNumber, __int64  FrameTime, int  FrameId, BOOL  *CaptureFrame);
   typedef void CALLBACK TOnMouseDownCb  (void *Object, void *Sender, int  VideoWindow, TMouseButton  Button, TMouseButton  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseDown_VideoCb  (void *Object, void *Sender, int  VideoWindow, TMouseButton  Button, TMouseButton  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseDown_WindowCb  (void *Object, void *Sender, int  VideoWindow, TMouseButton  Button, TMouseButton  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseEnterCb  (void *Object, void *Sender, int  VideoWindow);
   typedef void CALLBACK TOnMouseLeaveCb  (void *Object, void *Sender, int  VideoWindow);
   typedef void CALLBACK TOnMouseMoveCb  (void *Object, void *Sender, int  VideoWindow, int  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseMove_VideoCb  (void *Object, void *Sender, int  VideoWindow, int  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseMove_WindowCb  (void *Object, void *Sender, int  VideoWindow, int  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseUpCb  (void *Object, void *Sender, int  VideoWindow, TMouseButton  Button, TMouseButton  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseUp_VideoCb  (void *Object, void *Sender, int  VideoWindow, TMouseButton  Button, TMouseButton  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseUp_WindowCb  (void *Object, void *Sender, int  VideoWindow, TMouseButton  Button, TMouseButton  Shift, int  X, int  Y);
   typedef void CALLBACK TOnMouseWheelCb  (void *Object, void *Sender, int  VideoWindow, BOOL  DirectionUp, int  X, int  Y);
   typedef void CALLBACK TOnMultipurposeEncoderCompletedCb  (void *Object, void *Sender, TMultipurposeEncoderInstance  MultipurposeEncoderInstance);
   typedef void CALLBACK TOnMultipurposeEncoderErrorCb  (void *Object, void *Sender, TMultipurposeEncoderInstance  MultipurposeEncoderInstance);
   typedef void CALLBACK TOnMultipurposeEncoderProgressCb  (void *Object, void *Sender, TMultipurposeEncoderInstance  MultipurposeEncoderInstance);
   typedef void CALLBACK TOnNoVideoDevicesCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnNTPTimeStampCb  (void *Object, void *Sender, void *last_rtcp_ntp_time, unsigned int  last_rtcp_timestamp, unsigned int  delta_rtcp_ntp_time, unsigned int  delta_rtcp_timestamp, unsigned int  UTCDateTime, unsigned int  LocalDateTime);
   typedef void CALLBACK TOnPlayerBufferingDataCb  (void *Object, void *Sender, BOOL  StartingToBuffer);
   typedef void CALLBACK TOnPlayerDurationUpdatedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnPlayerEndOfPlaylistCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnPlayerEndOfStreamCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnPlayerOpenedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnPlayerStateChangedCb  (void *Object, void *Sender, TPlayerState  OldPlayerState, TPlayerState  NewPlayerState);
   typedef void CALLBACK TOnPlayerUpdateTrackbarPositionCb  (void *Object, void *Sender, unsigned int  FrameNumber, __int64  FrameTime, int  FrameId);
   typedef void CALLBACK TOnPreviewStartedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnRawAudioSampleCb  (void *Object, void *Sender, byte *pSampleBuffer, int  SampleBufferSize, int  SampleDataLength, TFormatType  FormatType, void *pFormat, void *pWaveFormatEx, __int64  SampleStartTime, __int64  SampleStopTime);
   typedef void CALLBACK TOnRawVideoSampleCb  (void *Object, void *Sender, byte *pSampleBuffer, int  SampleBufferSize, int  SampleDataLength, TFormatType  FormatType, void *pFormat, void *pBitmapInfoHeader, __int64  SampleStartTime, __int64  SampleStopTime);
   typedef void CALLBACK TOnRecordingCompletedCb  (void *Object, void *Sender, const wchar_t *FileName, BOOL  Success);
   typedef void CALLBACK TOnRecordingPausedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnRecordingReadyToStartCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnRecordingStartedCb  (void *Object, void *Sender, const wchar_t *FileName);
   typedef void CALLBACK TOnReencodingCompletedCb  (void *Object, void *Sender, const wchar_t *SourceFile, const wchar_t *DestFile, BOOL  Success);
   typedef void CALLBACK TOnReencodingProgressCb  (void *Object, void *Sender, int  Percent, __int64  Position, __int64  Duration);
   typedef void CALLBACK TOnReencodingStartedCb  (void *Object, void *Sender, const wchar_t *SourceFile, const wchar_t *DestFile);
   typedef void CALLBACK TOnReinitializingCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnResizeVideoCb  (void *Object, void *Sender, int  SourceWidth, int  SourceHeight);
   typedef void CALLBACK TOnStoppingGraphCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnStoppingGraphCompletedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnTextOverlayScrollingCompletedCb  (void *Object, void *Sender, int  TextOverlayIndex);
   typedef void CALLBACK TOnThirdPartyFilterAddedCb  (void *Object, void *Sender, TThirdPartyFilterList  Location, void *Intf, BOOL  *ShowDialog, BOOL  *SaveFilterProperties);
   typedef void CALLBACK TOnThirdPartyFilterConnectedCb  (void *Object, void *Sender, TThirdPartyFilterList  Location, void *Intf);
   typedef void CALLBACK TOnThirdPartyFilterConnected2Cb  (void *Object, void *Sender, const wchar_t *FilterName, void *Intf);
   typedef void CALLBACK TOnThreadSyncCb  (void *Object, void *Sender, TThreadSyncPoint  ThreadSyncPoint);
   typedef void CALLBACK TOnTVChannelScanCompletedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnTVChannelScanStartedCb  (void *Object, void *Sender, int  MinChannel, int  MaxChannel);
   typedef void CALLBACK TOnTVChannelSelectedCb  (void *Object, void *Sender, int  Channel, BOOL  Locked, int  DefaultVideoFrequency, int  OverriddenVideoFrequency, int  TunerVideoFrequency, int  TunerAudioFrequency);
   typedef void CALLBACK TOnVideoCompressionSettingsCb  (void *Object, void *Sender, BOOL  CanKeyFrameRate, BOOL  CanPFramesPerKeyFrame, BOOL  CanQuality, BOOL  CanWindowSize, BOOL  CanSpecifyDataRate, int  DefaultFrameRate, int  DefaultPFramesPerKey, double  DefaultQuality, int  DefaultWindowSize, int  DefaultDataRate);
   typedef void CALLBACK TOnVideoDeviceSelectedCb  (void *Object, void *Sender);
   typedef void CALLBACK TOnVideoFromBitmapsNextFrameNeededCb  (void *Object, void *Sender, BOOL  FirstSample);
//#endregion DeclareCallbackTypeH


class CVideoGrabber 
{
private:
    void *m_VideoGrabber;
public:
    CVideoGrabber();
    CVideoGrabber(void* classPtr);
    virtual ~CVideoGrabber();

    //#region DeclareFunctionsH
       void About ();
       int AnalogVideoStandardIndex (const wchar_t *Value);
       const wchar_t * ASFStreaming_GetAuthorizationList ();
       const wchar_t * ASFStreaming_GetConnectedClients ();
       int ASFStreaming_GetConnectedClientsCount ();
       BOOL ASFStreaming_ResetAuthorizations ();
       BOOL ASFStreaming_SetAuthorization (BOOL Allowed, const wchar_t *IP, const wchar_t *Mask);
       BOOL AssociateMultiplexedSlave (int InputNumber, int SlaveUniqueID);
       int AudioCompressorIndex (const wchar_t *Value);
       int AudioDeviceIndex (const wchar_t *Value);
       int AudioInputIndex (const wchar_t *Value);
       int AudioRendererIndex (const wchar_t *Value);
       BOOL AVIDuration (const wchar_t *AVIFile, __int64*Duration, __int64*FrameCount);
       const wchar_t * AVIHeaderInfo (const wchar_t *AVIFile, THeaderAttribute HeaderAttribute);
       BOOL AVIInfo (const wchar_t *AVIFile, __int64*Duration, __int64*FrameCount, int*_VideoWidth, int*_VideoHeight, double*VideoFrameRateFps, int*AvgBitRate, int*AudioChannels, int*AudioSamplesPerSec, int*AudioBitsPerSample, const wchar_t **VideoCodec, const wchar_t **AudioCodec);
       const wchar_t * AVIInfo2 (const wchar_t *AVIFile, TAVIInfoType AVIInfoType);
       BOOL CameraControlAuto (TCameraControl Setting);
       int CameraControlDefault (TCameraControl Setting);
       int CameraControlMax (TCameraControl Setting);
       int CameraControlMin (TCameraControl Setting);
       int CameraControlStep (TCameraControl Setting);
       int CameraControlValue (TCameraControl Setting);
       BOOL Cancel ();
       BOOL CanProcessMessages ();
       BOOL CaptureFrameRenderedTo (int DisplayIndex, TFrameCaptureDest Dest, const wchar_t *FileName);
       BOOL CaptureFrameSyncTo (TFrameCaptureDest Dest, const wchar_t *FileName);
       BOOL CaptureFrameTo (TFrameCaptureDest Dest, const wchar_t *FileName);
       void ClearHeaderAttributes ();
       void ClosePlayer ();
       void ContinueProcessing ();
       BOOL CreatePreallocCapFile ();
       void * CreateVideoGrabber ();
       void DestroyVideoGrabber ();
       void Display_SetLocation (int WindowLeft, int WindowTop, int WindowWidth, int WindowHeight);
       BOOL DrawBitmapOverFrame (HBITMAP BitmapHandle, BOOL Stretched, int LeftLocation, int TopLocation, int bmWidth, int bmHeight, BOOL Transparent_Enabled, BOOL UseTransparentColor, int Transparent_ColorValue, BOOL AlphaBlend_Enabled, int AlphaBlend_Value, BOOL ChromaKey, int ChromaKeyRGBColor, int ChromaKeyLeewayPercent);
       void DualDisplay_SetLocation (int WindowLeft, int WindowTop, int WindowWidth, int WindowHeight);
       double DVDInfo (const wchar_t *DVDRootDirectory, TDVDInfoType DVDInfoType, int TitleNumber);
       BOOL EnableMultiplexedInput (int InputNumber, BOOL Enable);
       BOOL EnableMultipurposeEncoder (TMultipurposeEncoderInstance MultipurposeEncoderType, BOOL Enable);
       BOOL EnableThreadMode ();
       BOOL Encoder_CloseOutputFile (int EncoderUniqueID);
       BOOL Encoder_GetInt (int EncoderID, TEncoder_int Setting, int*Value);
       BOOL Encoder_NewOutputFile (int EncoderUniqueID, const wchar_t *OutputFile, BOOL OpenPaused);
       BOOL Encoder_Pause (int EncoderUniqueID);
       BOOL Encoder_Resume (int EncoderUniqueID);
       BOOL Encoder_SetInt (int EncoderID, TEncoder_int Setting, int Value);
       BOOL Encoder_SetStr (int EncoderID, TEncoder_str Setting, const wchar_t *Value);
       int Encoders_CreateInstanceForRecording (const wchar_t *OutputFile);
       int Encoders_CreateInstanceForStreaming (const wchar_t *OutputURL);
       void Encoders_RemoveAllInstances ();
       BOOL Encoders_RemoveInstance (int EncoderUniqueID);
       BOOL EnumerateWindows ();
       void FastForwardPlayer ();
       int FindIndexInListByName (const wchar_t *List, const wchar_t *SearchedString, BOOL IsSubString, BOOL IgnoreCase);
       double GetCameraExposure ();
       const wchar_t * GetCameraExposureAsString ();
       BOOL GetFilterInterfaceByName (const wchar_t *FilterName, void **FilterIntf);
       int GetFrameBitmapInfo (TFrameBitmapInfoType FrameBitmapInfoType);
       __int64 GetFrameInfo (int FrameId, TFrameInfoId FrameInfoId);
       const wchar_t * GetFrameInfoString (TFrameInfoStringId FrameInfoStringId);
       BOOL GetFWCam1394 (const wchar_t *FWCam1394ID, int*Value, int*Flags, unsigned int*Capabilities, int*MinValue, int*MaxValue, int*Default);
       const wchar_t * GetFWCam1394List ();
       BOOL GetImageOverlay_AlphaBlend (int Index);
       int GetImageOverlay_AlphaBlendValue (int Index);
       BOOL GetImageOverlay_ChromaKey (int Index);
       int GetImageOverlay_ChromaKeyLeewayPercent (int Index);
       int GetImageOverlay_ChromaKeyRGBColor (int Index);
       BOOL GetImageOverlay_Enabled (int Index);
       int GetImageOverlay_Height (int Index);
       int GetImageOverlay_LeftLocation (int Index);
       double GetImageOverlay_RotationAngle (int Index);
       BOOL GetImageOverlay_StretchToVideoSize (int Index);
       int GetImageOverlay_TargetDisplay (int Index);
       int GetImageOverlay_TopLocation (int Index);
       BOOL GetImageOverlay_Transparent (int Index);
       int GetImageOverlay_TransparentColorValue (int Index);
       BOOL GetImageOverlay_UseTransparentColor (int Index);
       TVideoAlignment GetImageOverlay_VideoAlignment (int Index);
       int GetImageOverlay_Width (int Index);
       BOOL GetImageOverlayAlphaBlend ();
       int GetImageOverlayAlphaBlendValue ();
       BOOL GetImageOverlayChromaKey ();
       int GetImageOverlayChromaKeyLeewayPercent ();
       int GetImageOverlayChromaKeyRGBColor ();
       int GetImageOverlayHeight ();
       int GetImageOverlayLeftLocation ();
       double GetImageOverlayRotationAngle ();
       BOOL GetImageOverlayStretchToVideoSize ();
       int GetImageOverlayTargetDisplay ();
       int GetImageOverlayTopLocation ();
       BOOL GetImageOverlayTransparent ();
       int GetImageOverlayTransparentColorValue ();
       BOOL GetImageOverlayUseTransparentColor ();
       TVideoAlignment GetImageOverlayVideoAlignment ();
       int GetImageOverlayWidth ();
       const wchar_t * GetItemNameFromList (const wchar_t *List, int ItemIndex);
       int GetLastAverageStreamValue (TStreamType StreamType);
       HBITMAP GetLastFrameAsHBITMAP (int BufferIndex, BOOL WithOverlays, int SrcLeftLocation, int SrcTopLocation, int SrcWidth, int SrcHeight, int DestWidth, int DestHeight, int BitmapColorBitCount);
       void * GetLastFrameBitmapBits (int BufferIndex, BOOL WithOverlays, BOOL ReleaseFrame);
       void * GetLastFrameBitmapBits2 (int BufferIndex, BOOL WithOverlays, BOOL ReleaseFrame, int*BitmapWidth, int*BitmapHeight, int*BitmapLineSize, int*BitmapSize, int*BitmapBitsPerPixel);
       const wchar_t * GetLogString (TLogType Value);
       int GetMiscDeviceControl (TMiscDeviceControl MiscDeviceControl, int Index);
       const wchar_t * GetMultipurposeEncoderSettings (TMultipurposeEncoderInstance MultipurposeEncoderType);
       const wchar_t * GetNDISessions (BOOL AsXML, BOOL ReportURLInfo);
       int GetNearestVideoHeight (int PreferredVideoWidth, int PreferredVideoHeight);
       void GetNearestVideoSize (int PreferredVideoWidth, int PreferredVideoHeight, int*NearestVideoWidth, int*NearestVideoHeight);
       int GetNearestVideoWidth (int PreferredVideoWidth, int PreferredVideoHeight);
       double GetPixelsDistance (int x1, int y1, int x2, int y2);
       const wchar_t * GetPlaylist ();
       int GetRGBPixelAt (int x, int y);
       TTextOverlayAlign GetTextOverlay_Align (int Index);
       BOOL GetTextOverlay_AlphaBlend (int Index);
       int GetTextOverlay_AlphaBlendValue (int Index);
       int GetTextOverlay_BkColor (int Index);
       BOOL GetTextOverlay_Enabled (int Index);
       INT_PTR GetTextOverlay_Font (int Index);
       int GetTextOverlay_FontColor (int Index);
       int GetTextOverlay_FontSize (int Index);
       int GetTextOverlay_GradientColor (int Index);
       TTextOverlayGradientMode GetTextOverlay_GradientMode (int Index);
       BOOL GetTextOverlay_HighResFont (int Index);
       int GetTextOverlay_Left (int Index);
       TTextOrientation GetTextOverlay_Orientation (int Index);
       int GetTextOverlay_Right (int Index);
       BOOL GetTextOverlay_Scrolling (int Index);
       int GetTextOverlay_ScrollingSpeed (int Index);
       BOOL GetTextOverlay_Shadow (int Index);
       int GetTextOverlay_ShadowColor (int Index);
       TCardinalDirection GetTextOverlay_ShadowDirection (int Index);
       const wchar_t * GetTextOverlay_String (int Index);
       int GetTextOverlay_TargetDisplay (int Index);
       int GetTextOverlay_Top (int Index);
       BOOL GetTextOverlay_Transparent (int Index);
       TVideoAlignment GetTextOverlay_VideoAlignment (int Index);
       TTextOverlayAlign GetTextOverlayAlign ();
       BOOL GetTextOverlayAlphaBlend ();
       int GetTextOverlayAlphaBlendValue ();
       int GetTextOverlayBkColor ();
       BOOL GetTextOverlayEnabled ();
       INT_PTR GetTextOverlayFont ();
       int GetTextOverlayFontColor ();
       int GetTextOverlayFontSize ();
       int GetTextOverlayGradientColor ();
       TTextOverlayGradientMode GetTextOverlayGradientMode ();
       BOOL GetTextOverlayHighResFont ();
       int GetTextOverlayLeft ();
       TTextOrientation GetTextOverlayOrientation ();
       int GetTextOverlayRight ();
       BOOL GetTextOverlayScrolling ();
       int GetTextOverlayScrollingSpeed ();
       BOOL GetTextOverlayShadow ();
       int GetTextOverlayShadowColor ();
       TCardinalDirection GetTextOverlayShadowDirection ();
       const wchar_t * GetTextOverlayString ();
       int GetTextOverlayTargetDisplay ();
       int GetTextOverlayTop ();
       BOOL GetTextOverlayTransparent ();
       TVideoAlignment GetTextOverlayVideoAlignment ();
       BOOL GetTranslatedCoordinates (int DisplayIndex, int NativeX, int NativeY, int*TranslatedX, int*TranslatedY);
       int GetTVChannelInfo (TTVChannelInfo Value);
       BOOL GetVideoCompressionSettings (int*DataRate, int*KeyFrameRate, int*PFramesPerKeyFrame, int*WindowSize, double*Quality, BOOL*CanQuality, BOOL*CanCrunch, BOOL*CanKeyFrame, BOOL*CanBFrame, BOOL*CanWindow);
       BOOL GetVideoControlMode (TVideoControl Mode);
       int GetVideoHeightFromIndex (int SizeIndex);
       BOOL GetVideoSizeFromIndex (int SizeIndex, int*_VideoWidth, int*_VideoHeight);
       int GetVideoWidthFromIndex (int SizeIndex);
       BOOL GetVMR9ImageAdjustmentBounds (BOOL MainDisplay, TVMR9ImageAdjustment VMR9ControlSetting, int*MinValue, int*MaxValue, int*StepSize, int*DefaultValue, int*CurrentValue);
       TVuMeter GetVuMeter_Enabled (int Index);
       unsigned int GetVUMeterSetting (unsigned int ChannelIndex, TVUMeterSetting VUMeterSetting);
       TGraphState GraphState ();
       void InitSyncMgr (BOOL FromDeb, BOOL Is_DM);
       BOOL IsAudioDeviceASoundCard (int DeviceIndex);
       BOOL IsAudioDeviceConnected (int DeviceIndex);
       BOOL IsAudioRendererConnected (int RendererIndex);
       BOOL IsCameraControlSettingAvailable (TCameraControl Setting);
       BOOL IsDialogAvailable (TDialog Dialog);
       BOOL IsDirectX8OrHigherInstalled ();
       BOOL IsDVDevice (int Index);
       BOOL IsPlaylistActive ();
       BOOL IsPreviewStarted ();
       BOOL IsServerResponding (const wchar_t *URL, int Timeout_Seconds);
       BOOL IsURLResponding ();
       TTriState IsURLVideoStreamAvailable (int TimeOut_Ms);
       BOOL IsVideoControlModeAvailable (TVideoControl Mode);
       BOOL IsVideoDeviceConnected (int DeviceIndex);
       BOOL IsVideoQualitySettingAvailable (TVideoQuality Setting);
       BOOL IsVideoSignalDetected (BOOL DetectConnexantBlueScreen, BOOL DetectCustomRGB, int CustomR, int CustomG, int CustomB, BOOL UseAsMaxValues);
       BOOL IsVMR9ImageAdjustmentAvailable (BOOL MainDisplay);
       BOOL LoadCompressorSettingsFromDataString (BOOL IsVideoCompressor, int CompressorIndex, const wchar_t *DataString);
       BOOL LoadCompressorSettingsFromTextFile (BOOL IsVideoCompressor, int CompressorIndex, const wchar_t *FileName);
       BOOL MixAudioSamples (void *pSampleBuffer, int SampleBufferSize, int SampleDataLength, TFormatType SampleFormatType, void *pFormat, __int64 SampleStartTime, __int64 SampleStopTime);
       BOOL Mixer_Activation (int Id, BOOL Activate);
       int Mixer_AddAudioToMixer (int SourceUniqueID);
       int Mixer_AddToMixer (int SourceUniqueID, int SourceVideoInput, int MosaicLine, int MosaicColumn, int AlternatedGroup, int AlternatedTimeIntervalInMs, BOOL ReplacePreviouslyAdded, BOOL CanEraseBackground);
       BOOL Mixer_AudioActivation (int Id, BOOL Activate);
       BOOL Mixer_RemoveAudioFromMixer (int Id);
       BOOL Mixer_RemoveFromMixer (int Id);
       BOOL Mixer_SetOverlayAttributes (int Id, BOOL Transparent_Enabled, BOOL UseTransparentColor, int Transparent_ColorValue, BOOL AlphaBlend_Enabled, int AlphaBlend_Value, BOOL ChromaKey_Enabled, int ChromaKeyRGBColor, int ChromaKeyLeewayPercent, double RotationAngle);
       int Mixer_SetupPIPFromSource (int SourceUniqueID, int Source_Left, int Source_Top, int Source_Width, int Source_Height, BOOL ActivatePIP, int PIP_Left, int PIP_Top, int PIP_Width, int PIP_Height, BOOL MoveToTop);
       int Monitor_Primary_Index ();
       BOOL MonitorBounds (int MonitorNumber, int*LeftBound, int*TopBound, int*RightBound, int*BottomBound);
       int MonitorsCount ();
       int MotionDetector_CellColorIntensity (TRGBSelector RGBSelector, int x, int y);
       double MotionDetector_CellMotionRatio (int x, int y);
       const wchar_t * MotionDetector_Get2DTextGrid ();
       const wchar_t * MotionDetector_Get2DTextMotion ();
       BOOL MotionDetector_GetCellLocation (int x, int y, int*XLocation, int*YLocation);
       BOOL MotionDetector_GetCellSensitivity (int x, int y, int*Value);
       BOOL MotionDetector_GetCellSize (int*XSize, int*YSize);
       int MotionDetector_GlobalColorIntensity (TRGBSelector RGBSelector);
       void MotionDetector_GloballyIncOrDecSensitivity (int Value);
       void MotionDetector_Reset ();
       void MotionDetector_ResetGlobalSensitivity (int Value);
       BOOL MotionDetector_SetCellSensitivity (int x, int y, int Value);
       void MotionDetector_SetGridSize (int x, int y);
       void MotionDetector_ShowGridDialog ();
       void MotionDetector_TriggerNow ();
       BOOL MotionDetector_UseThisReferenceSample (HBITMAP Bitmap_, const wchar_t *BMPFile, const wchar_t *JPEGFile);
       int MPEGProgramSetting (TMPEGProgramSetting MPEGProgramSettingValue, int Value);
       int MultiplexerIndex (const wchar_t *Value);
       const wchar_t * MultipurposeEncoder_Convert100nsToHhMmSsZzz (__int64 Time100ns);
       BOOL MultipurposeEncoder_GetCurrentInfo (TMultipurposeEncoderInstance MultipurposeEncoderType, unsigned int*InputsTotalDurationMs, unsigned int*FrameCount, double*fps, double*quality, double*SizeWrittenKb, unsigned int*TimeMs, double*BitRateKbps, unsigned int*DuplicatedCount, unsigned int*DroppedCount, int*ExitCode);
       const wchar_t * MultipurposeEncoder_GetLastLog (TMultipurposeEncoderInstance MultipurposeEncoderType);
       BOOL MultipurposeEncoder_QuickConfigure_UDPStreaming_H264 (BOOL LogTofile, BOOL VideoEnabled, BOOL AudioEnabled, const wchar_t *DestinationIP, int DestinationPort, int VideoBitRateKb, int AudioBitRateKb);
       BOOL MultipurposeEncoder_ReindexClip (const wchar_t *CurrentFileName, const wchar_t *NewFileName);
       void NotifyPlayerTrackbarAction (TTrackbarAction TrackbarAction);
       BOOL ONVIF_GetBool (const wchar_t *ParamIdentifier, BOOL*Value);
       BOOL ONVIF_GetDouble (const wchar_t *ParamIdentifier, double*Value);
       BOOL ONVIF_GetInt (const wchar_t *ParamIdentifier, int*Value);
       BOOL ONVIF_GetStr (const wchar_t *ParamIdentifier, const wchar_t **Value);
       BOOL ONVIF_SetBool (const wchar_t *ParamIdentifier, BOOL Value);
       BOOL ONVIF_SetDouble (const wchar_t *ParamIdentifier, double Value);
       BOOL ONVIF_SetInt (const wchar_t *ParamIdentifier, const wchar_t *Value);
       BOOL ONVIF_SetStr (const wchar_t *ParamIdentifier, const wchar_t *Value);
       const wchar_t * ONVIFDeviceInfo (TONVIFDeviceInfo ONVIFDeviceInfoType);
       BOOL ONVIFPTZGetLimits (double*Pan_Min, double*Pan_Max, double*Tilt_Min, double*Tilt_Max, double*Zoom_Min, double*Zoom_Max);
       BOOL ONVIFPTZGetPosition (double*Pan, double*Tilt, double*Zoom, __int64*UTCTime, int*IsMoving);
       BOOL ONVIFPTZPreset (const wchar_t *PresetAction, const wchar_t *PresetName);
       BOOL ONVIFPTZSendAuxiliaryCommand (const wchar_t *AuxiliaryCommand);
       BOOL ONVIFPTZSetPosition (double Pan, double Tilt, double Zoom, double SpeedRatio, BOOL IsRelative);
       BOOL ONVIFPTZStartMove (const wchar_t *PTZType, BOOL OppositeDirection, double SpeedRatio, int DurationMs);
       BOOL ONVIFPTZStopMove (const wchar_t *PTZType);
       BOOL ONVIFSnapShot (BOOL OnRawVideoSampleCallbackEnabled, BOOL SaveToFile, const wchar_t *FileName);
       BOOL OpenDVD ();
       BOOL OpenPlayer ();
       BOOL OpenPlayerAtFramePositions (__int64 StartFrame, __int64 StopFrame, BOOL KeepBounds, BOOL CloseAndReopenIfAlreadyOpened);
       BOOL OpenPlayerAtTimePositions (__int64 StartTime, __int64 StopTime, BOOL KeepBounds, BOOL CloseAndReopenIfAlreadyOpened);
       void PausePlayer ();
       BOOL PausePreview ();
       BOOL PauseRecording ();
       BOOL PlayerFrameStep (int FrameCount);
       BOOL Playlist (TPlaylist PlaylistAction, const wchar_t *VideoClip);
       int PointGreyConfig (TPointGreyConfig ConfigType, unsigned int*PGRActionValue, unsigned int ulRegister, unsigned int ulMode, unsigned int ulLeft, unsigned int ulTop, unsigned int ulWidth, unsigned int ulHeight, unsigned int ulPercentage, unsigned int ulFormat);
       BOOL PutMiscDeviceControl (TMiscDeviceControl MiscDeviceControl, int Index, int Value);
       unsigned int RecordingKBytesWrittenToDisk ();
       BOOL RecordToNewFileNow (const wchar_t *NewRecordingFileName, BOOL ResetStreamTime);
       BOOL ReencodeVideoClip (const wchar_t *SourceVideoClip, const wchar_t *NewVideoClip, BOOL IncludeVideoStream, BOOL IncludeAudioStream, BOOL UseFrameGrabber, BOOL UseCurrentVideoCompressor, BOOL UseCurrentAudioCompressor);
       void RefreshDevicesAndCompressorsLists ();
       void RefreshPlayerOverlays ();
       BOOL ResetPreview ();
       BOOL ResetVideoDeviceSettings ();
       BOOL ResumePreview ();
       BOOL ResumeRecording ();
       void RetrieveInitialXYAfterRotation (int X, int Y, int*OriginalX, int*OriginalY);
       void RewindPlayer ();
       void RunPlayer ();
       void RunPlayerBackwards ();
       const wchar_t * SaveCompressorSettingsToDataString (BOOL IsVideoCompressor, int CompressorIndex);
       BOOL SaveCompressorSettingsToTextFile (BOOL IsVideoCompressor, int CompressorIndex, const wchar_t *FileName);
       BOOL ScheduleNextActionAtAbsoluteDateTime (int Year, int Month, int Day, int Hour, int Min, int Sec, int MSec);
       BOOL ScheduleNextActionAtAbsoluteTime (int Hour, int Min, int Sec, int MSec);
       BOOL ScheduleNextActionFromNow (int Day, int Hour, int Min, int Sec, int MSec);
       BOOL ScreenRecordingUsingCoordinates (BOOL FunctionEnabled, int scLeft, int scTop, int scWidth, int scHeight);
       BOOL SendCameraCommand (int Pan, int Tilt, BOOL Relative);
       BOOL SendDVCommand (TDVCommand DVCommand);
       BOOL SendImageToVideoFromBitmaps (const wchar_t *ImageFilePath, HBITMAP BitmapHandle, BOOL CanFreeBitmapHandle, BOOL EndOfData);
       BOOL SendImageToVideoFromBitmaps2 (void *pBtmapInfo, byte *pBitmapBits, BOOL EndOfData);
       BOOL SendIPCameraCommand (const wchar_t *IPCameraCommand);
       void Set_OnDeviceArrivalOrRemoval (void*Value);
       void SetAudioRendererAdditional (int Value);
       void SetAuthentication (TAuthenticationType AuthenticationType, const wchar_t *UserName, const wchar_t *Password);
       void SetAVIMuxConfig (TAVIMuxConfig AVIMuxSetting, int Value);
       void SetCallbackSender (void *Sender);
       BOOL SetCameraControl (TCameraControl Setting, BOOL SetAuto, BOOL SetDefault, int SetValue);
       void SetCameraExposure (double Value);
       BOOL SetDisplayAssociatedRenderer (int DisplayIndex, const wchar_t *Value);
       BOOL SetDisplayLocation (int DisplayIndex, int WindowLeft, int WindowTop, int WindowWidth, int WindowHeight);
       BOOL SetDisplayParent (int DisplayIndex, int DisplayParent);
       void SetFrameCaptureBounds (int LeftPosition, int TopPosition, int RightPosition, int BottomPosition);
       BOOL SetFWCam1394 (const wchar_t *FWCam1394ID, int Value);
       void SetHeaderAttribute (THeaderAttribute HeaderAttribute, const wchar_t *Value);
       void SetImageOverlay_AlphaBlend (int Index, BOOL Value);
       void SetImageOverlay_AlphaBlendValue (int Index, int Value);
       void SetImageOverlay_Attributes (int LeftLocation, int TopLocation, int StretchedWidth, int StretchedHeight, BOOL Transparent_Enabled, BOOL UseTransparentColor, int Transparent_ColorValue, BOOL AlphaBlend_Enabled, int AlphaBlend_Value);
       void SetImageOverlay_Attributes2 (int Index, int LeftLocation, int TopLocation, int StretchedWidth, int StretchedHeight, BOOL Transparent_Enabled, BOOL UseTransparentColor, int Transparent_ColorValue, BOOL AlphaBlend_Enabled, int AlphaBlend_Value);
       void SetImageOverlay_ChromaKey (int Index, BOOL Value);
       void SetImageOverlay_ChromaKeyLeewayPercent (int Index, int Value);
       void SetImageOverlay_ChromaKeyRGBColor (int Index, int Value);
       void SetImageOverlay_Enabled (int Index, BOOL Value);
       void SetImageOverlay_Height (int Index, int Value);
       void SetImageOverlay_LeftLocation (int Index, int Value);
       void SetImageOverlay_RotationAngle (int Index, double Value);
       void SetImageOverlay_StretchToVideoSize (int Index, BOOL Value);
       void SetImageOverlay_TargetDisplay (int Index, int Value);
       void SetImageOverlay_TopLocation (int Index, int Value);
       void SetImageOverlay_Transparent (int Index, BOOL Value);
       void SetImageOverlay_TransparentColorValue (int Index, int Value);
       void SetImageOverlay_UseTransparentColor (int Index, BOOL Value);
       void SetImageOverlay_VideoAlignment (int Index, TVideoAlignment Value);
       void SetImageOverlay_Width (int Index, int Value);
       void SetImageOverlayAlphaBlend (BOOL Value);
       void SetImageOverlayAlphaBlendValue (int Value);
       void SetImageOverlayChromaKey (BOOL Value);
       void SetImageOverlayChromaKeyLeewayPercent (int Value);
       void SetImageOverlayChromaKeyRGBColor (int Value);
       BOOL SetImageOverlayFromBMPFile (const wchar_t *FileName);
       BOOL SetImageOverlayFromBMPFile2 (int Index, const wchar_t *FileName);
       BOOL SetImageOverlayFromHBitmap (HBITMAP Bitmap);
       BOOL SetImageOverlayFromHBitmap2 (int Index, HBITMAP Bitmap);
       BOOL SetImageOverlayFromHBitmap3 (int Index, HBITMAP Bitmap, BOOL ReleaseBitmap);
       BOOL SetImageOverlayFromImageFile (const wchar_t *FileName);
       BOOL SetImageOverlayFromImageFile2 (int Index, const wchar_t *FileName);
       BOOL SetImageOverlayFromJPEGFile (const wchar_t *FileName);
       BOOL SetImageOverlayFromJPEGFile2 (int Index, const wchar_t *FileName);
       void SetImageOverlayHeight (int Value);
       void SetImageOverlayLeftLocation (int Value);
       void SetImageOverlayRotationAngle (double Value);
       void SetImageOverlayStretchToVideoSize (BOOL Value);
       void SetImageOverlayTargetDisplay (int Value);
       void SetImageOverlayTopLocation (int Value);
       void SetImageOverlayTransparent (BOOL Value);
       void SetImageOverlayTransparentColorValue (int Value);
       void SetImageOverlayUseTransparentColor (BOOL Value);
       void SetImageOverlayVideoAlignment (TVideoAlignment Value);
       void SetImageOverlayWidth (int Value);
       BOOL SetIPCameraSetting (TIPCameraSetting Setting, int Value);
       void SetLocation (int lLeft, int lTop, int lWidth, int lHeight);
       BOOL SetLogoFromBMPFile (const wchar_t *FileName);
       BOOL SetLogoFromHBitmap (HBITMAP Bitmap);
       BOOL SetLogoFromJPEGFile (const wchar_t *FileName);
       void SetMultiplexerFilterByName (const wchar_t *Value);
       BOOL SetMultipurposeEncoderSettings (TMultipurposeEncoderInstance MultipurposeEncoderType, const wchar_t *Settings);
       void SetOnDoEvents (void*Value);
       void SetParentWindow (HWND Value);
       void SetTextOverlay_Align (int Index, TTextOverlayAlign Value);
       void SetTextOverlay_AlphaBlend (int Index, BOOL Value);
       void SetTextOverlay_AlphaBlendValue (int Index, int Value);
       void SetTextOverlay_BkColor (int Index, int Value);
       void SetTextOverlay_CustomVar (int Index, int VarIndex, const wchar_t *VarText);
       void SetTextOverlay_Enabled (int Index, BOOL Value);
       void SetTextOverlay_Font (int Index, INT_PTR Value);
       void SetTextOverlay_FontColor (int Index, int Value);
       void SetTextOverlay_FontSize (int Index, int Value);
       void SetTextOverlay_GradientColor (int Index, int Value);
       void SetTextOverlay_GradientMode (int Index, TTextOverlayGradientMode Value);
       void SetTextOverlay_HighResFont (int Index, BOOL Value);
       void SetTextOverlay_Left (int Index, int Value);
       void SetTextOverlay_Orientation (int Index, TTextOrientation Value);
       void SetTextOverlay_Right (int Index, int Value);
       void SetTextOverlay_Scrolling (int Index, BOOL Value);
       void SetTextOverlay_ScrollingSpeed (int Index, int Value);
       void SetTextOverlay_Shadow (int Index, BOOL Value);
       void SetTextOverlay_ShadowColor (int Index, int Value);
       void SetTextOverlay_ShadowDirection (int Index, TCardinalDirection Value);
       void SetTextOverlay_String (int Index, const wchar_t *Value);
       void SetTextOverlay_TargetDisplay (int Index, int Value);
       void SetTextOverlay_Top (int Index, int Value);
       void SetTextOverlay_Transparent (int Index, BOOL Value);
       void SetTextOverlay_VideoAlignment (int Index, TVideoAlignment Value);
       void SetTextOverlayAlign (TTextOverlayAlign Value);
       void SetTextOverlayAlphaBlend (BOOL Value);
       void SetTextOverlayAlphaBlendValue (int Value);
       void SetTextOverlayBkColor (int Value);
       void SetTextOverlayEnabled (BOOL Value);
       void SetTextOverlayFont (INT_PTR Value);
       void SetTextOverlayFontColor (int Value);
       void SetTextOverlayFontSize (int Value);
       void SetTextOverlayGradientColor (int Value);
       void SetTextOverlayGradientMode (TTextOverlayGradientMode Value);
       void SetTextOverlayHighResFont (BOOL Value);
       void SetTextOverlayLeft (int Value);
       void SetTextOverlayOrientation (TTextOrientation Value);
       void SetTextOverlayRight (int Value);
       void SetTextOverlayScrolling (BOOL Value);
       void SetTextOverlayScrollingSpeed (int Value);
       void SetTextOverlayShadow (BOOL Value);
       void SetTextOverlayShadowColor (int Value);
       void SetTextOverlayShadowDirection (TCardinalDirection Value);
       void SetTextOverlayString (const wchar_t *Value);
       void SetTextOverlayTargetDisplay (int Value);
       void SetTextOverlayTop (int Value);
       void SetTextOverlayTransparent (BOOL Value);
       void SetTextOverlayVideoAlignment (TVideoAlignment Value);
       BOOL SetVideoCompressionDefaults ();
       BOOL SetVideoCompressionSettings (int DataRate, int KeyFrameRate, int PFramesPerKeyFrame, int WindowSize, double Quality);
       BOOL SetVideoControlMode (BOOL FlipHorizontal, BOOL FlipVertical, BOOL ExternalTriggerEnable, BOOL Trigger);
       BOOL SetVideoControlMode2 (TVideoControl Mode, BOOL Value);
       BOOL SetVideoQuality (TVideoQuality Setting, BOOL SetAuto, BOOL SetDefault, int SetValue);
       BOOL SetVMR9ImageAdjustmentValue (BOOL MainDisplay, TVMR9ImageAdjustment VMR9ControlSetting, int Value, BOOL FixRange);
       void SetVuMeter_Enabled (int Index, TVuMeter Value);
       void SetVUMeterSetting (unsigned int ChannelIndex, TVUMeterSetting VUMeterSetting, INT_PTR Value);
       BOOL SetWindowRecordingByHandle (HWND Window_Handle);
       BOOL SetWindowRecordingByName (const wchar_t *WindowName, BOOL ExactMatch);
       BOOL SetWindowTransparency (HWND WndHandle, BOOL UseColorKey, BOOL UseAlpha, int AlphaValue);
       void ShowDebugWindow ();
       BOOL ShowDialog (TDialog Dialog);
       BOOL StartAudioRecording ();
       BOOL StartAudioRendering ();
       BOOL StartPreview ();
       BOOL StartRecording ();
       BOOL StartReencoding ();
       BOOL StartSynchronized ();
       BOOL Stop ();
       void StopPlayer ();
       void StopPreview ();
       void StopRecording ();
       BOOL StopReencoding ();
       int StreamInterface_PushData (byte *Buffer, int BufferSize);
       BOOL TextOverlay_CreateCustomFont (int Index, int fHeight, int fWidth, int fEscapement, int fOrientation, int fWeight, BOOL fItalic, BOOL fUnderline, BOOL fStrikeOut, unsigned int fCharSet, unsigned int fOutputPrecision, unsigned int fClipPrecision, unsigned int fQuality, unsigned int fPitchAndFamily, const wchar_t *FontFacename);
       BOOL ThirdPartyFilter_AddToList (TThirdPartyFilterList Location, const wchar_t *GUIDString, const wchar_t *OptionalDLLFilePath, const wchar_t *FilterName, BOOL Enable, BOOL CanSaveFilterState);
       BOOL ThirdPartyFilter_ClearList ();
       BOOL ThirdPartyFilter_Enable (TThirdPartyFilterList Location, const wchar_t *GUIDString, BOOL Enable);
       BOOL ThirdPartyFilter_RemoveFromList (TThirdPartyFilterList Location, const wchar_t *GUIDString);
       BOOL ThirdPartyFilter_ShowDialog (TThirdPartyFilterList Location, const wchar_t *GUIDString);
       BOOL TVClearFrequencyOverrides ();
       BOOL TVGetMinMaxChannels (int*MinChannel, int*MaxChannel);
       int TVSetChannelFrequencyOverride (int TVChannel, int FrequencyInHz);
       BOOL TVStartAutoScan ();
       BOOL TVStartAutoScanChannels (int MinChannel, int MaxChannel, int Interval_ms);
       BOOL TVStopAutoScan ();
       void UpdateTrackbarBounds ();
       void UseNearestVideoSize (int PreferredWidth, int PreferredHeight, BOOL Stretch);
       BOOL v360_AddYawPitchRoll (double Yaw, double Pitch, double Roll);
       double v360_GetAngle (Tv360_InOut Direction, Tv360_Angle Angle);
       void v360_GetYawPitchRoll (double*Yaw, double*Pitch, double*Roll);
       void v360_ResetAnglesToDefault ();
       BOOL v360_SetAngle (Tv360_InOut Direction, Tv360_Angle Angle, double Value);
       BOOL v360_SetInterpolation (Tv360_Interpolation Value);
       BOOL v360_SetProjection (Tv360_InOut Direction, Tv360_Projection Value);
       BOOL v360_SetStereoFormat (Tv360_InOut Direction, Tv360_StereoFormat Value);
       BOOL v360_SetTranspose (Tv360_InOut Direction, BOOL Value);
       BOOL v360_SetYawPitchRoll (double Yaw, double Pitch, double Roll);
       BOOL VDECGetHorizontalLocked (int*plLocked);
       BOOL VDECGetNumberOfLines (int*plNumberOfLines);
       BOOL VDECGetOutputEnable (int*plOutputEnable);
       BOOL VDECGetVCRHorizontalLocking (int*plVCRHorizontalLocking);
       BOOL VDECPutOutputEnable (int lOutputEnable);
       BOOL VDECPutTVFormat (int lAnalogVideoStandard);
       BOOL VDECPutVCRHorizontalLocking (int lVCRHorizontalLocking);
       int VideoCompressorIndex (const wchar_t *Value);
       int VideoDeviceIndex (const wchar_t *Value);
       int VideoDeviceIndexFromId (const wchar_t *Value);
       int VideoFormatIndex (const wchar_t *Value);
       BOOL VideoFromImages_CreateSetOfBitmaps ();
       int VideoInputIndex (const wchar_t *Value);
       BOOL VideoQualityAuto (TVideoQuality Setting);
       int VideoQualityDefault (TVideoQuality Setting);
       int VideoQualityMax (TVideoQuality Setting);
       int VideoQualityMin (TVideoQuality Setting);
       int VideoQualityStep (TVideoQuality Setting);
       int VideoQualityValue (TVideoQuality Setting);
       int VideoSizeIndex (const wchar_t *Value);
       int VideoSubtypeIndex (const wchar_t *Value);
       void * WaitForLastFrameBitmapBits (int BufferIndex, BOOL WithOverlays, BOOL ReleaseFrame, int*BitmapWidth, int*BitmapHeight, int*BitmapLineSize, int*BitmapSize, int*BitmapBitsPerPixel, __int64*FrameTime, __int64*FrameNumber);
       BOOL WriteScriptCommand (const wchar_t *ScriptType, const wchar_t *ScriptArgument);
       BOOL zReservedInternal1 (void *Param1, void *Param2);
       BOOL zReservedInternal2 (BOOL Param1);
       INT_PTR zReservedInternal3 ();
    //#endregion DeclareFunctionsH

    //#region DeclarePropertiesH
       const wchar_t *GetAnalogVideoStandards ();
       
       int GetAnalogVideoStandardsCount ();
       
       const wchar_t *GetASFProfiles ();
       
       int GetASFProfilesCount ();
       
       int GetAudioBalance ();
       void SetAudioBalance (int Value);
       
       const wchar_t *GetAudioCompressorName ();
       
       const wchar_t *GetAudioCompressors ();
       
       int GetAudioCompressorsCount ();
       
       int GetAudioInputBalance ();
       void SetAudioInputBalance (int Value);
       
       int GetAudioInputLevel ();
       void SetAudioInputLevel (int Value);
       
       BOOL GetAudioInputMono ();
       void SetAudioInputMono (BOOL Value);
       
       const wchar_t *GetAudioInputs ();
       
       int GetAudioInputsCount ();
       
       const wchar_t *GetAudioDeviceName ();
       
       const wchar_t *GetAudioDevices ();
       
       int GetAudioDevicesCount ();
       
       const wchar_t *GetAudioFormats ();
       
       const wchar_t *GetAudioRendererName ();
       
       const wchar_t *GetAudioRenderers ();
       
       int GetAudioRenderersCount ();
       
       int GetAudioVolume ();
       void SetAudioVolume (int Value);
       
       int GetBufferCount ();
       void SetBufferCount (int Value);
       
       BOOL GetBusy ();
       
       double GetRecordingDuration ();
       
       const wchar_t *GetRecordingFourCC ();
       
       int GetCropping_YMax ();
       
       int GetCropping_XMax ();
       
       double GetCurrentFrameRate ();
       
       TCurrentState GetCurrentState ();
       
       __int64 GetDeliveredFrames ();
       
       const wchar_t *GetDirectShowFilters ();
       
       int GetDirectShowFiltersCount ();
       
       int GetDisplay_VideoHeight ();
       
       int GetDisplay_VideoWidth ();
       
       HWND GetDisplay_VideoWindowHandle ();
       
       HWND GetDualDisplay_VideoWindowHandle ();
       
       int GetDroppedFrames ();
       
       int GetDualDisplay_VideoHeight ();
       
       int GetDualDisplay_VideoWidth ();
       
       TFrameGrabberRGBFormat GetFrameGrabberCurrentRGBFormat ();
       
       BOOL GetHoldRecording ();
       void SetHoldRecording (BOOL Value);
       
       int GetImageOverlaySelector ();
       void SetImageOverlaySelector (int Value);
       
       double GetImageRatio ();
       
       BOOL GetInFrameProgressEvent ();
       
       BOOL GetIsAnalogVideoDecoderAvailable ();
       
       BOOL GetIsAudioCrossbarAvailable ();
       
       TTriState GetIsAudioInputBalanceAvailable ();
       
       BOOL GetIsCameraControlAvailable ();
       
       BOOL GetIsDigitalVideoIn ();
       
       BOOL GetIsDVCommandAvailable ();
       
       BOOL GetIsHorizontalSyncLocked ();
       
       BOOL GetIsMpegStream ();
       
       TTriState GetIsPlayerAudioStreamAvailable ();
       
       TTriState GetIsPlayerVideoStreamAvailable ();
       
       BOOL GetIsRecordingPaused ();
       
       BOOL GetIsTimeCodeReaderAvailable ();
       
       BOOL GetIsTVTunerAvailable ();
       
       BOOL GetIsTVAutoTuneRunning ();
       
       BOOL GetIsTVAudioAvailable ();
       
       BOOL GetIsVideoControlAvailable ();
       
       BOOL GetIsVideoCrossbarAvailable ();
       
       BOOL GetIsVideoInterlaced ();
       
       BOOL GetIsVideoQualityAvailable ();
       
       BOOL GetIsVideoPortAvailable ();
       
       BOOL GetIsWDMVideoDriver ();
       
       const wchar_t *GetLast_BurstFrameCapture_FileName ();
       
       const wchar_t *GetLast_CaptureFrameTo_FileName ();
       
       const wchar_t *GetLast_Recording_FileName ();
       
       const wchar_t *GetLast_Clip_Played ();
       
       double GetMotionDetector_GlobalMotionRatio ();
       
       int GetMotionDetector_GridXCount ();
       
       int GetMotionDetector_GridYCount ();
       
       BOOL GetMotionDetector_IsGridValid ();
       
       TMpegStreamType GetMpegStreamType ();
       void SetMpegStreamType (TMpegStreamType Value);
       
       const wchar_t *GetMultiplexerName ();
       
       const wchar_t *GetMultiplexers ();
       
       int GetMultiplexersCount ();
       
       int GetPlaylistIndex ();
       void SetPlaylistIndex (int Value);
       
       const wchar_t *GetPlayerAudioCodec ();
       
       __int64 GetPlayerDuration ();
       void SetPlayerDuration (__int64 Value);
       
       __int64 GetPlayerFrameCount ();
       
       __int64 GetPlayerFramePosition ();
       void SetPlayerFramePosition (__int64 Value);
       
       int GetPlayerOpenProgressPercent ();
       
       TPlayerState GetPlayerState ();
       
       __int64 GetPlayerTimePosition ();
       void SetPlayerTimePosition (__int64 Value);
       
       double GetPlayerFrameRate ();
       
       const wchar_t *GetPlayerVideoCodec ();
       
       int GetRecordingBacktimedFramesCount ();
       void SetRecordingBacktimedFramesCount (int Value);
       
       BOOL GetRecordingCanPause ();
       void SetRecordingCanPause (BOOL Value);
       
       int GetRecordingHeight ();
       
       int GetRecordingWidth ();
       
       int GetSendToDV_DeviceIndex ();
       void SetSendToDV_DeviceIndex (int Value);
       
       int GetSpeakerBalance ();
       void SetSpeakerBalance (int Value);
       
       int GetSpeakerVolume ();
       void SetSpeakerVolume (int Value);
       
       const wchar_t *GetStreamingURL ();
       
       const wchar_t *GetSystemTempPath ();
       
       int GetTextOverlay_Selector ();
       void SetTextOverlay_Selector (int Value);
       
       int GetTVChannel ();
       void SetTVChannel (int Value);
       
       int GetTVCountryCode ();
       void SetTVCountryCode (int Value);
       
       TTunerInputType GetTVTunerInputType ();
       void SetTVTunerInputType (TTunerInputType Value);
       
       TTunerMode GetTunerMode ();
       void SetTunerMode (TTunerMode Value);
       
       int GetUniqueID ();
       
       BOOL GetVCRHorizontalLocking ();
       void SetVCRHorizontalLocking (BOOL Value);
       
       const wchar_t *GetVideoCompressorName ();
       
       const wchar_t *GetVideoCompressors ();
       
       int GetVideoCompressorsCount ();
       
       const wchar_t *GetVideoFormats ();
       
       int GetVideoFormatsCount ();
       
       const wchar_t *GetVideoInputs ();
       
       int GetVideoInputsCount ();
       
       const wchar_t *GetVideoDeviceName ();
       
       const wchar_t *GetVideoDevices ();
       
       const wchar_t *GetVideoDevicesId ();
       
       int GetVideoDevicesCount ();
       
       int GetVideoHeight ();
       
       int GetVideoHeight_PreferredAspectRatio ();
       
       int GetVideoWidth ();
       
       int GetVideoWidth_PreferredAspectRatio ();
       
       const wchar_t *GetVideoSizes ();
       
       int GetVideoSizesCount ();
       
       const wchar_t *GetVideoSources ();
       
       int GetVideoSourcesCount ();
       
       const wchar_t *GetVideoSubtypes ();
       
       int GetVideoSubtypesCount ();
       
       BOOL GetAdjustOverlayAspectRatio ();
       void SetAdjustOverlayAspectRatio (BOOL Value);
       
       BOOL GetAdjustPixelAspectRatio ();
       void SetAdjustPixelAspectRatio (BOOL Value);
       
       TAero GetAero ();
       void SetAero (TAero Value);
       
       int GetAnalogVideoStandard ();
       void SetAnalogVideoStandard (int Value);
       
       TApplicationPriority GetApplicationPriority ();
       void SetApplicationPriority (TApplicationPriority Value);
       
       int GetASFAudioBitRate ();
       void SetASFAudioBitRate (int Value);
       
       int GetASFAudioChannels ();
       void SetASFAudioChannels (int Value);
       
       int GetASFBufferWindow ();
       void SetASFBufferWindow (int Value);
       
       TASFDeinterlaceMode GetASFDeinterlaceMode ();
       void SetASFDeinterlaceMode (TASFDeinterlaceMode Value);
       
       BOOL GetASFDirectStreamingKeepClientsConnected ();
       void SetASFDirectStreamingKeepClientsConnected (BOOL Value);
       
       BOOL GetASFFixedFrameRate ();
       void SetASFFixedFrameRate (BOOL Value);
       
       const wchar_t *GetASFMediaServerPublishingPoint ();
       void SetASFMediaServerPublishingPoint (const wchar_t *Value);
       
       const wchar_t *GetASFMediaServerTemplatePublishingPoint ();
       void SetASFMediaServerTemplatePublishingPoint (const wchar_t *Value);
       
       BOOL GetASFMediaServerRemovePublishingPointAfterDisconnect ();
       void SetASFMediaServerRemovePublishingPointAfterDisconnect (BOOL Value);
       
       int GetASFNetworkPort ();
       void SetASFNetworkPort (int Value);
       
       int GetASFNetworkMaxUsers ();
       void SetASFNetworkMaxUsers (int Value);
       
       int GetASFProfile ();
       void SetASFProfile (int Value);
       
       const wchar_t *GetASFProfileFromCustomFile ();
       void SetASFProfileFromCustomFile (const wchar_t *Value);
       
       TASFProfileVersion GetASFProfileVersion ();
       void SetASFProfileVersion (TASFProfileVersion Value);
       
       int GetASFVideoBitRate ();
       void SetASFVideoBitRate (int Value);
       
       double GetASFVideoFrameRate ();
       void SetASFVideoFrameRate (double Value);
       
       int GetASFVideoHeight ();
       void SetASFVideoHeight (int Value);
       
       int GetASFVideoMaxKeyFrameSpacing ();
       void SetASFVideoMaxKeyFrameSpacing (int Value);
       
       int GetASFVideoQuality ();
       void SetASFVideoQuality (int Value);
       
       int GetASFVideoWidth ();
       void SetASFVideoWidth (int Value);
       
       double GetAspectRatioToUse ();
       void SetAspectRatioToUse (double Value);
       
       BOOL GetAssociateAudioAndVideoDevices ();
       void SetAssociateAudioAndVideoDevices (BOOL Value);
       
       BOOL GetAVIDurationUpdated ();
       void SetAVIDurationUpdated (BOOL Value);
       
       TAudioChannelRenderMode GetAudioChannelRenderMode ();
       void SetAudioChannelRenderMode (TAudioChannelRenderMode Value);
       
       int GetAudioCompressor ();
       void SetAudioCompressor (int Value);
       
       int GetAudioDevice ();
       void SetAudioDevice (int Value);
       
       BOOL GetAudioDeviceRendering ();
       void SetAudioDeviceRendering (BOOL Value);
       
       TAudioFormat GetAudioFormat ();
       void SetAudioFormat (TAudioFormat Value);
       
       int GetAudioInput ();
       void SetAudioInput (int Value);
       
       BOOL GetAudioPeakEvent ();
       void SetAudioPeakEvent (BOOL Value);
       
       BOOL GetAudioRecording ();
       void SetAudioRecording (BOOL Value);
       
       int GetAudioRenderer ();
       void SetAudioRenderer (int Value);
       
       int GetAudioStreamNumber ();
       void SetAudioStreamNumber (int Value);
       
       BOOL GetAudioSyncAdjustmentEnabled ();
       void SetAudioSyncAdjustmentEnabled (BOOL Value);
       
       int GetAudioSyncAdjustment ();
       void SetAudioSyncAdjustment (int Value);
       
       TAudioSource GetAudioSource ();
       void SetAudioSource (TAudioSource Value);
       
       BOOL GetAutoConnectRelatedPins ();
       void SetAutoConnectRelatedPins (BOOL Value);
       
       TAutoFileName GetAutoFileName ();
       void SetAutoFileName (TAutoFileName Value);
       
       const wchar_t *GetAutoFileNameDateTimeFormat ();
       void SetAutoFileNameDateTimeFormat (const wchar_t *Value);
       
       int GetAutoFileNameMinDigits ();
       void SetAutoFileNameMinDigits (int Value);
       
       const wchar_t *GetAutoFilePrefix ();
       void SetAutoFilePrefix (const wchar_t *Value);
       
       const wchar_t *GetAutoFileSuffix ();
       void SetAutoFileSuffix (const wchar_t *Value);
       
       BOOL GetAutoRefreshPreview ();
       void SetAutoRefreshPreview (BOOL Value);
       
       BOOL GetAutoStartPlayer ();
       void SetAutoStartPlayer (BOOL Value);
       
       BOOL GetAVIFormatOpenDML ();
       void SetAVIFormatOpenDML (BOOL Value);
       
       BOOL GetAVIFormatOpenDMLCompatibilityIndex ();
       void SetAVIFormatOpenDMLCompatibilityIndex (BOOL Value);
       
       int GetBackgroundColor ();
       void SetBackgroundColor (int Value);
       
       int GetBurstCount ();
       void SetBurstCount (int Value);
       
       int GetBurstInterval ();
       void SetBurstInterval (int Value);
       
       BOOL GetBurstMode ();
       void SetBurstMode (BOOL Value);
       
       TFrameCaptureDest GetBurstType ();
       void SetBurstType (TFrameCaptureDest Value);
       
       BOOL GetCameraControlSettings ();
       void SetCameraControlSettings (BOOL Value);
       
       const wchar_t *GetCaptureFileExt ();
       void SetCaptureFileExt (const wchar_t *Value);
       
       int GetColorKey ();
       void SetColorKey (int Value);
       
       BOOL GetColorKeyEnabled ();
       void SetColorKeyEnabled (BOOL Value);
       
       TCompressionMode GetCompressionMode ();
       void SetCompressionMode (TCompressionMode Value);
       
       TCompressionType GetCompressionType ();
       void SetCompressionType (TCompressionType Value);
       
       BOOL GetDisplay_Active ();
       void SetDisplay_Active (BOOL Value);
       
       BOOL GetDisplay_AlphaBlendEnabled ();
       void SetDisplay_AlphaBlendEnabled (BOOL Value);
       
       int GetDisplay_AlphaBlendValue ();
       void SetDisplay_AlphaBlendValue (int Value);
       
       BOOL GetDisplay_AutoSize ();
       void SetDisplay_AutoSize (BOOL Value);
       
       TAspectRatio GetDisplay_AspectRatio ();
       void SetDisplay_AspectRatio (TAspectRatio Value);
       
       BOOL GetDisplay_Embedded ();
       void SetDisplay_Embedded (BOOL Value);
       
       BOOL GetDisplay_Embedded_FitParent ();
       void SetDisplay_Embedded_FitParent (BOOL Value);
       
       BOOL GetDisplay_FullScreen ();
       void SetDisplay_FullScreen (BOOL Value);
       
       int GetDisplay_Height ();
       void SetDisplay_Height (int Value);
       
       int GetDisplay_Left ();
       void SetDisplay_Left (int Value);
       
       int GetDisplay_Monitor ();
       void SetDisplay_Monitor (int Value);
       
       BOOL GetDisplay_MouseMovesWindow ();
       void SetDisplay_MouseMovesWindow (BOOL Value);
       
       int GetDisplay_PanScanRatio ();
       void SetDisplay_PanScanRatio (int Value);
       
       BOOL GetDisplay_StayOnTop ();
       void SetDisplay_StayOnTop (BOOL Value);
       
       int GetDisplay_Top ();
       void SetDisplay_Top (int Value);
       
       BOOL GetDisplay_TransparentColorEnabled ();
       void SetDisplay_TransparentColorEnabled (BOOL Value);
       
       int GetDisplay_TransparentColorValue ();
       void SetDisplay_TransparentColorValue (int Value);
       
       BOOL GetDisplay_VideoPortEnabled ();
       void SetDisplay_VideoPortEnabled (BOOL Value);
       
       BOOL GetDisplay_Visible ();
       void SetDisplay_Visible (BOOL Value);
       
       int GetDisplay_Width ();
       void SetDisplay_Width (int Value);
       
       BOOL GetDoubleBuffered ();
       void SetDoubleBuffered (BOOL Value);
       
       int GetDroppedFramesPollingInterval ();
       void SetDroppedFramesPollingInterval (int Value);
       
       BOOL GetDualDisplay_Active ();
       void SetDualDisplay_Active (BOOL Value);
       
       BOOL GetDualDisplay_AlphaBlendEnabled ();
       void SetDualDisplay_AlphaBlendEnabled (BOOL Value);
       
       int GetDualDisplay_AlphaBlendValue ();
       void SetDualDisplay_AlphaBlendValue (int Value);
       
       BOOL GetDualDisplay_AutoSize ();
       void SetDualDisplay_AutoSize (BOOL Value);
       
       TAspectRatio GetDualDisplay_AspectRatio ();
       void SetDualDisplay_AspectRatio (TAspectRatio Value);
       
       BOOL GetDualDisplay_Embedded ();
       void SetDualDisplay_Embedded (BOOL Value);
       
       BOOL GetDualDisplay_Embedded_FitParent ();
       void SetDualDisplay_Embedded_FitParent (BOOL Value);
       
       BOOL GetDualDisplay_FullScreen ();
       void SetDualDisplay_FullScreen (BOOL Value);
       
       int GetDualDisplay_Height ();
       void SetDualDisplay_Height (int Value);
       
       int GetDualDisplay_Left ();
       void SetDualDisplay_Left (int Value);
       
       int GetDualDisplay_Monitor ();
       void SetDualDisplay_Monitor (int Value);
       
       BOOL GetDualDisplay_MouseMovesWindow ();
       void SetDualDisplay_MouseMovesWindow (BOOL Value);
       
       int GetDualDisplay_PanScanRatio ();
       void SetDualDisplay_PanScanRatio (int Value);
       
       BOOL GetDualDisplay_StayOnTop ();
       void SetDualDisplay_StayOnTop (BOOL Value);
       
       int GetDualDisplay_Top ();
       void SetDualDisplay_Top (int Value);
       
       BOOL GetDualDisplay_TransparentColorEnabled ();
       void SetDualDisplay_TransparentColorEnabled (BOOL Value);
       
       int GetDualDisplay_TransparentColorValue ();
       void SetDualDisplay_TransparentColorValue (int Value);
       
       BOOL GetDualDisplay_VideoPortEnabled ();
       void SetDualDisplay_VideoPortEnabled (BOOL Value);
       
       BOOL GetDualDisplay_Visible ();
       void SetDualDisplay_Visible (BOOL Value);
       
       int GetDualDisplay_Width ();
       void SetDualDisplay_Width (int Value);
       
       BOOL GetDVDateTimeEnabled ();
       void SetDVDateTimeEnabled (BOOL Value);
       
       int GetDVDTitle ();
       void SetDVDTitle (int Value);
       
       int GetDVDiscontinuityMinimumInterval ();
       void SetDVDiscontinuityMinimumInterval (int Value);
       
       TDVVideoFormat GetDVEncoder_VideoFormat ();
       void SetDVEncoder_VideoFormat (TDVVideoFormat Value);
       
       TDVSize GetDVEncoder_VideoResolution ();
       void SetDVEncoder_VideoResolution (TDVSize Value);
       
       TDVVideoStandard GetDVEncoder_VideoStandard ();
       void SetDVEncoder_VideoStandard (TDVVideoStandard Value);
       
       BOOL GetDVRgb219 ();
       void SetDVRgb219 (BOOL Value);
       
       BOOL GetDVReduceFrameRate ();
       void SetDVReduceFrameRate (BOOL Value);
       
       BOOL GetDVRecordingInNativeFormatSeparatesStreams ();
       void SetDVRecordingInNativeFormatSeparatesStreams (BOOL Value);
       
       BOOL GetDVTimeCodeEnabled ();
       void SetDVTimeCodeEnabled (BOOL Value);
       
       const wchar_t *GetExtraDLLPath ();
       void SetExtraDLLPath (const wchar_t *Value);
       
       BOOL GetEventNotificationSynchrone ();
       void SetEventNotificationSynchrone (BOOL Value);
       
       BOOL GetCropping_Enabled ();
       void SetCropping_Enabled (BOOL Value);
       
       int GetCropping_Height ();
       void SetCropping_Height (int Value);
       
       BOOL GetCropping_Outbounds ();
       void SetCropping_Outbounds (BOOL Value);
       
       int GetCropping_Width ();
       void SetCropping_Width (int Value);
       
       int GetCropping_X ();
       void SetCropping_X (int Value);
       
       int GetCropping_Y ();
       void SetCropping_Y (int Value);
       
       double GetCropping_Zoom ();
       void SetCropping_Zoom (double Value);
       
       BOOL GetFixFlickerOrBlackCapture ();
       void SetFixFlickerOrBlackCapture (BOOL Value);
       
       BOOL GetFrameCaptureWithoutOverlay ();
       void SetFrameCaptureWithoutOverlay (BOOL Value);
       
       int GetFrameCaptureHeight ();
       void SetFrameCaptureHeight (int Value);
       
       int GetFrameCaptureWidth ();
       void SetFrameCaptureWidth (int Value);
       
       int GetFrameCaptureZoomSize ();
       void SetFrameCaptureZoomSize (int Value);
       
       TFrameGrabber GetFrameGrabber ();
       void SetFrameGrabber (TFrameGrabber Value);
       
       TFrameGrabberRGBFormat GetFrameGrabberRGBFormat ();
       void SetFrameGrabberRGBFormat (TFrameGrabberRGBFormat Value);
       
       BOOL GetFrameNumberStartsFromZero ();
       void SetFrameNumberStartsFromZero (BOOL Value);
       
       double GetFrameRate ();
       void SetFrameRate (double Value);
       
       int GetFrameRateDivider ();
       void SetFrameRateDivider (int Value);
       
       int GetGetLastFrameWaitTimeoutMs ();
       void SetGetLastFrameWaitTimeoutMs (int Value);
       
       BOOL GetImageOverlayEnabled ();
       void SetImageOverlayEnabled (BOOL Value);
       
       BOOL GetImageOverlay_AlphaBlend ();
       void SetImageOverlay_AlphaBlend (BOOL Value);
       
       int GetImageOverlay_AlphaBlendValue ();
       void SetImageOverlay_AlphaBlendValue (int Value);
       
       BOOL GetImageOverlay_ChromaKey ();
       void SetImageOverlay_ChromaKey (BOOL Value);
       
       int GetImageOverlay_ChromaKeyLeewayPercent ();
       void SetImageOverlay_ChromaKeyLeewayPercent (int Value);
       
       int GetImageOverlay_ChromaKeyRGBColor ();
       void SetImageOverlay_ChromaKeyRGBColor (int Value);
       
       int GetImageOverlay_Height ();
       void SetImageOverlay_Height (int Value);
       
       int GetImageOverlay_LeftLocation ();
       void SetImageOverlay_LeftLocation (int Value);
       
       TVideoAlignment GetImageOverlay_VideoAlignment ();
       void SetImageOverlay_VideoAlignment (TVideoAlignment Value);
       
       double GetImageOverlay_RotationAngle ();
       void SetImageOverlay_RotationAngle (double Value);
       
       BOOL GetImageOverlay_StretchToVideoSize ();
       void SetImageOverlay_StretchToVideoSize (BOOL Value);
       
       int GetImageOverlay_TopLocation ();
       void SetImageOverlay_TopLocation (int Value);
       
       BOOL GetImageOverlay_Transparent ();
       void SetImageOverlay_Transparent (BOOL Value);
       
       int GetImageOverlay_TransparentColorValue ();
       void SetImageOverlay_TransparentColorValue (int Value);
       
       BOOL GetImageOverlay_UseTransparentColor ();
       void SetImageOverlay_UseTransparentColor (BOOL Value);
       
       int GetImageOverlay_Width ();
       void SetImageOverlay_Width (int Value);
       
       int GetImageOverlay_TargetDisplay ();
       void SetImageOverlay_TargetDisplay (int Value);
       
       const wchar_t *GetIPCameraURL ();
       void SetIPCameraURL (const wchar_t *Value);
       
       TJPEGPerformance GetJPEGPerformance ();
       void SetJPEGPerformance (TJPEGPerformance Value);
       
       BOOL GetJPEGProgressiveDisplay ();
       void SetJPEGProgressiveDisplay (BOOL Value);
       
       int GetJPEGQuality ();
       void SetJPEGQuality (int Value);
       
       const wchar_t *GetLicenseString ();
       void SetLicenseString (const wchar_t *Value);
       
       BOOL GetLogoDisplayed ();
       void SetLogoDisplayed (BOOL Value);
       
       TLogoLayout GetLogoLayout ();
       void SetLogoLayout (TLogoLayout Value);
       
       int GetMixAudioSamples_CurrentSourceLevel ();
       void SetMixAudioSamples_CurrentSourceLevel (int Value);
       
       int GetMixAudioSamples_ExternalSourceLevel ();
       void SetMixAudioSamples_ExternalSourceLevel (int Value);
       
       int GetMixer_MosaicColumns ();
       void SetMixer_MosaicColumns (int Value);
       
       int GetMixer_MosaicLines ();
       void SetMixer_MosaicLines (int Value);
       
       BOOL GetMotionDetector_CompareBlue ();
       void SetMotionDetector_CompareBlue (BOOL Value);
       
       BOOL GetMotionDetector_CompareGreen ();
       void SetMotionDetector_CompareGreen (BOOL Value);
       
       BOOL GetMotionDetector_GreyScale ();
       void SetMotionDetector_GreyScale (BOOL Value);
       
       BOOL GetMotionDetector_CompareRed ();
       void SetMotionDetector_CompareRed (BOOL Value);
       
       BOOL GetMotionDetector_Enabled ();
       void SetMotionDetector_Enabled (BOOL Value);
       
       const wchar_t *GetMotionDetector_Grid ();
       void SetMotionDetector_Grid (const wchar_t *Value);
       
       double GetMotionDetector_MaxDetectionsPerSecond ();
       void SetMotionDetector_MaxDetectionsPerSecond (double Value);
       
       int GetMotionDetector_ReduceCPULoad ();
       void SetMotionDetector_ReduceCPULoad (int Value);
       
       int GetMotionDetector_MotionResetMs ();
       void SetMotionDetector_MotionResetMs (int Value);
       
       BOOL GetMotionDetector_ReduceVideoNoise ();
       void SetMotionDetector_ReduceVideoNoise (BOOL Value);
       
       BOOL GetMotionDetector_Triggered ();
       void SetMotionDetector_Triggered (BOOL Value);
       
       BOOL GetMouseWheelEventEnabled ();
       void SetMouseWheelEventEnabled (BOOL Value);
       
       BOOL GetMouseWheelControlsZoomAtCursor ();
       void SetMouseWheelControlsZoomAtCursor (BOOL Value);
       
       BOOL GetMultiplexedInputEmulation ();
       void SetMultiplexedInputEmulation (BOOL Value);
       
       TMultiplexedRole GetMultiplexedRole ();
       void SetMultiplexedRole (TMultiplexedRole Value);
       
       int GetMultiplexedSwitchDelay ();
       void SetMultiplexedSwitchDelay (int Value);
       
       int GetMultiplexedStabilizationDelay ();
       void SetMultiplexedStabilizationDelay (int Value);
       
       int GetMultiplexer ();
       void SetMultiplexer (int Value);
       
       BOOL GetMuteAudioRendering ();
       void SetMuteAudioRendering (BOOL Value);
       
       const wchar_t *GetName ();
       void SetName (const wchar_t *Value);
       
       TNDIBandwidthType GetNDIBandwidthType ();
       void SetNDIBandwidthType (TNDIBandwidthType Value);
       
       const wchar_t *GetNDIGroups ();
       void SetNDIGroups (const wchar_t *Value);
       
       const wchar_t *GetNDIName ();
       void SetNDIName (const wchar_t *Value);
       
       int GetNDIReceiveTimeoutMs ();
       void SetNDIReceiveTimeoutMs (int Value);
       
       TNetworkStreaming GetNetworkStreaming ();
       void SetNetworkStreaming (TNetworkStreaming Value);
       
       TNetworkStreamingType GetNetworkStreamingType ();
       void SetNetworkStreamingType (TNetworkStreamingType Value);
       
       TNotificationMethod GetNotificationMethod ();
       void SetNotificationMethod (TNotificationMethod Value);
       
       int GetNotificationSleepTime ();
       void SetNotificationSleepTime (int Value);
       
       TThreadPriority GetNotificationPriority ();
       void SetNotificationPriority (TThreadPriority Value);
       
       BOOL GetOnFrameBitmapEventSynchrone ();
       void SetOnFrameBitmapEventSynchrone (BOOL Value);
       
       BOOL GetOpenURLAsync ();
       void SetOpenURLAsync (BOOL Value);
       
       BOOL GetOverlayAfterTransform ();
       void SetOverlayAfterTransform (BOOL Value);
       
       BOOL GetPlayerAudioRendering ();
       void SetPlayerAudioRendering (BOOL Value);
       
       TDVSize GetPlayerDVSize ();
       void SetPlayerDVSize (TDVSize Value);
       
       int GetPlayerFastSeekSpeedRatio ();
       void SetPlayerFastSeekSpeedRatio (int Value);
       
       const wchar_t *GetPlayerFileName ();
       void SetPlayerFileName (const wchar_t *Value);
       
       const wchar_t *GetPlayerForcedCodec ();
       void SetPlayerForcedCodec (const wchar_t *Value);
       
       THwAccel GetPlayerHwAccel ();
       void SetPlayerHwAccel (THwAccel Value);
       
       BOOL GetPlayerRefreshPausedDisplay ();
       void SetPlayerRefreshPausedDisplay (BOOL Value);
       
       double GetPlayerRefreshPausedDisplayFrameRate ();
       void SetPlayerRefreshPausedDisplayFrameRate (double Value);
       
       double GetPlayerSpeedRatio ();
       void SetPlayerSpeedRatio (double Value);
       
       BOOL GetPlayerSpeedRatioConstantAudioPitch ();
       void SetPlayerSpeedRatioConstantAudioPitch (BOOL Value);
       
       BOOL GetPlayerTrackBarSynchrone ();
       void SetPlayerTrackBarSynchrone (BOOL Value);
       
       BOOL GetPreallocCapFileCopiedAfterRecording ();
       void SetPreallocCapFileCopiedAfterRecording (BOOL Value);
       
       BOOL GetPreallocCapFileEnabled ();
       void SetPreallocCapFileEnabled (BOOL Value);
       
       const wchar_t *GetPreallocCapFileName ();
       void SetPreallocCapFileName (const wchar_t *Value);
       
       int GetPreallocCapFileSizeInMB ();
       void SetPreallocCapFileSizeInMB (int Value);
       
       int GetPreviewZoomSize ();
       void SetPreviewZoomSize (int Value);
       
       int GetRecordingAudioBitRate ();
       void SetRecordingAudioBitRate (int Value);
       
       int GetRecordingVideoBitRate ();
       void SetRecordingVideoBitRate (int Value);
       
       const wchar_t *GetRecordingFileName ();
       void SetRecordingFileName (const wchar_t *Value);
       
       int GetRecordingFileSizeMaxInMB ();
       void SetRecordingFileSizeMaxInMB (int Value);
       
       BOOL GetRecordingInNativeFormat ();
       void SetRecordingInNativeFormat (BOOL Value);
       
       TRecordingMethod GetRecordingMethod ();
       void SetRecordingMethod (TRecordingMethod Value);
       
       BOOL GetRecordingPauseCreatesNewFile ();
       void SetRecordingPauseCreatesNewFile (BOOL Value);
       
       BOOL GetRecordingOnMotion_Enabled ();
       void SetRecordingOnMotion_Enabled (BOOL Value);
       
       double GetRecordingOnMotion_MotionThreshold ();
       void SetRecordingOnMotion_MotionThreshold (double Value);
       
       TRecordingTimer GetRecordingTimer ();
       void SetRecordingTimer (TRecordingTimer Value);
       
       int GetRecordingTimerInterval ();
       void SetRecordingTimerInterval (int Value);
       
       int GetRecordingOnMotion_NoMotionPauseDelayMs ();
       void SetRecordingOnMotion_NoMotionPauseDelayMs (int Value);
       
       const wchar_t *GetReencoding_NewVideoClip ();
       void SetReencoding_NewVideoClip (const wchar_t *Value);
       
       const wchar_t *GetReencoding_SourceVideoClip ();
       void SetReencoding_SourceVideoClip (const wchar_t *Value);
       
       TCursors GetBusyCursor ();
       void SetBusyCursor (TCursors Value);
       
       TCursors GetVideoCursor ();
       void SetVideoCursor (TCursors Value);
       
       TCursors GetNormalCursor ();
       void SetNormalCursor (TCursors Value);
       
       __int64 GetReencoding_StartTime ();
       void SetReencoding_StartTime (__int64 Value);
       
       __int64 GetReencoding_StartFrame ();
       void SetReencoding_StartFrame (__int64 Value);
       
       __int64 GetReencoding_StopTime ();
       void SetReencoding_StopTime (__int64 Value);
       
       __int64 GetReencoding_StopFrame ();
       void SetReencoding_StopFrame (__int64 Value);
       
       BOOL GetReencoding_IncludeAudioStream ();
       void SetReencoding_IncludeAudioStream (BOOL Value);
       
       BOOL GetReencoding_IncludeVideoStream ();
       void SetReencoding_IncludeVideoStream (BOOL Value);
       
       TRecordingMethod GetReencoding_Method ();
       void SetReencoding_Method (TRecordingMethod Value);
       
       BOOL GetReencoding_UseAudioCompressor ();
       void SetReencoding_UseAudioCompressor (BOOL Value);
       
       BOOL GetReencoding_UseFrameGrabber ();
       void SetReencoding_UseFrameGrabber (BOOL Value);
       
       BOOL GetReencoding_UseVideoCompressor ();
       void SetReencoding_UseVideoCompressor (BOOL Value);
       
       BOOL GetReencoding_WMVOutput ();
       void SetReencoding_WMVOutput (BOOL Value);
       
       BOOL GetQuickDeviceInitialization ();
       void SetQuickDeviceInitialization (BOOL Value);
       
       BOOL GetRawAudioSampleCapture ();
       void SetRawAudioSampleCapture (BOOL Value);
       
       BOOL GetRawCaptureAsyncEvent ();
       void SetRawCaptureAsyncEvent (BOOL Value);
       
       TRawSampleCaptureLocation GetRawSampleCaptureLocation ();
       void SetRawSampleCaptureLocation (TRawSampleCaptureLocation Value);
       
       BOOL GetRawVideoSampleCapture ();
       void SetRawVideoSampleCapture (BOOL Value);
       
       TRecordingSize GetRecordingSize ();
       void SetRecordingSize (TRecordingSize Value);
       
       int GetScreenRecordingSizePercent ();
       void SetScreenRecordingSizePercent (int Value);
       
       BOOL GetScreenRecordingLayeredWindows ();
       void SetScreenRecordingLayeredWindows (BOOL Value);
       
       int GetScreenRecordingMonitor ();
       void SetScreenRecordingMonitor (int Value);
       
       BOOL GetScreenRecordingNonVisibleWindows ();
       void SetScreenRecordingNonVisibleWindows (BOOL Value);
       
       BOOL GetScreenRecordingThroughClipboard ();
       void SetScreenRecordingThroughClipboard (BOOL Value);
       
       BOOL GetScreenRecordingWithCursor ();
       void SetScreenRecordingWithCursor (BOOL Value);
       
       BOOL GetSpeakerControl ();
       void SetSpeakerControl (BOOL Value);
       
       const wchar_t *GetStoragePath ();
       void SetStoragePath (const wchar_t *Value);
       
       TStoragePathMode GetStoragePathMode ();
       void SetStoragePathMode (TStoragePathMode Value);
       
       BOOL GetStoreDeviceSettingsInRegistry ();
       void SetStoreDeviceSettingsInRegistry (BOOL Value);
       
       TSynchronizationRole GetSynchronizationRole ();
       void SetSynchronizationRole (TSynchronizationRole Value);
       
       BOOL GetSynchronized ();
       void SetSynchronized (BOOL Value);
       
       BOOL GetSyncCommands ();
       void SetSyncCommands (BOOL Value);
       
       TSyncPreview GetSyncPreview ();
       void SetSyncPreview (TSyncPreview Value);
       
       BOOL GetTextOverlay_Enabled ();
       void SetTextOverlay_Enabled (BOOL Value);
       
       int GetTextOverlay_FontColor ();
       void SetTextOverlay_FontColor (int Value);
       
       int GetTextOverlay_FontSize ();
       void SetTextOverlay_FontSize (int Value);
       
       BOOL GetTextOverlay_HighResFont ();
       void SetTextOverlay_HighResFont (BOOL Value);
       
       int GetTextOverlay_Left ();
       void SetTextOverlay_Left (int Value);
       
       int GetTextOverlay_Top ();
       void SetTextOverlay_Top (int Value);
       
       int GetTextOverlay_Right ();
       void SetTextOverlay_Right (int Value);
       
       TTextOrientation GetTextOverlay_Orientation ();
       void SetTextOverlay_Orientation (TTextOrientation Value);
       
       BOOL GetTextOverlay_Scrolling ();
       void SetTextOverlay_Scrolling (BOOL Value);
       
       int GetTextOverlay_ScrollingSpeed ();
       void SetTextOverlay_ScrollingSpeed (int Value);
       
       BOOL GetTextOverlay_Shadow ();
       void SetTextOverlay_Shadow (BOOL Value);
       
       int GetTextOverlay_ShadowColor ();
       void SetTextOverlay_ShadowColor (int Value);
       
       TCardinalDirection GetTextOverlay_ShadowDirection ();
       void SetTextOverlay_ShadowDirection (TCardinalDirection Value);
       
       int GetTextOverlay_BkColor ();
       void SetTextOverlay_BkColor (int Value);
       
       TTextOverlayAlign GetTextOverlay_Align ();
       void SetTextOverlay_Align (TTextOverlayAlign Value);
       
       BOOL GetTextOverlay_AlphaBlend ();
       void SetTextOverlay_AlphaBlend (BOOL Value);
       
       int GetTextOverlay_AlphaBlendValue ();
       void SetTextOverlay_AlphaBlendValue (int Value);
       
       TTextOverlayGradientMode GetTextOverlay_GradientMode ();
       void SetTextOverlay_GradientMode (TTextOverlayGradientMode Value);
       
       int GetTextOverlay_GradientColor ();
       void SetTextOverlay_GradientColor (int Value);
       
       TVideoAlignment GetTextOverlay_VideoAlignment ();
       void SetTextOverlay_VideoAlignment (TVideoAlignment Value);
       
       const wchar_t *GetTextOverlay_String ();
       void SetTextOverlay_String (const wchar_t *Value);
       
       int GetTextOverlay_TargetDisplay ();
       void SetTextOverlay_TargetDisplay (int Value);
       
       BOOL GetTextOverlay_Transparent ();
       void SetTextOverlay_Transparent (BOOL Value);
       
       INT_PTR GetTextOverlay_Font ();
       void SetTextOverlay_Font (INT_PTR Value);
       
       const wchar_t *GetThirdPartyDeinterlacer ();
       void SetThirdPartyDeinterlacer (const wchar_t *Value);
       
       BOOL GetTranslateMouseCoordinates ();
       void SetTranslateMouseCoordinates (BOOL Value);
       
       BOOL GetTVUseFrequencyOverrides ();
       void SetTVUseFrequencyOverrides (BOOL Value);
       
       int GetTunerFrequency ();
       void SetTunerFrequency (int Value);
       
       BOOL GetUseClock ();
       void SetUseClock (BOOL Value);
       
       const wchar_t *GetVersion ();
       void SetVersion (const wchar_t *Value);
       
       BOOL Getv360_Enabled ();
       void Setv360_Enabled (BOOL Value);
       
       double Getv360_AspectRatio ();
       void Setv360_AspectRatio (double Value);
       
       int Getv360_MouseActionPercent ();
       void Setv360_MouseActionPercent (int Value);
       
       TV360_MouseAction Getv360_MouseAction ();
       void Setv360_MouseAction (TV360_MouseAction Value);
       
       Tv360_Angle Getv360_MasterAngle ();
       void Setv360_MasterAngle (Tv360_Angle Value);
       
       int GetVideoDevice ();
       void SetVideoDevice (int Value);
       
       int GetVideoCompression_DataRate ();
       void SetVideoCompression_DataRate (int Value);
       
       int GetVideoCompression_KeyFrameRate ();
       void SetVideoCompression_KeyFrameRate (int Value);
       
       int GetVideoCompression_PFramesPerKeyFrame ();
       void SetVideoCompression_PFramesPerKeyFrame (int Value);
       
       double GetVideoCompression_Quality ();
       void SetVideoCompression_Quality (double Value);
       
       int GetVideoCompression_WindowSize ();
       void SetVideoCompression_WindowSize (int Value);
       
       int GetVideoCompressor ();
       void SetVideoCompressor (int Value);
       
       BOOL GetVideoControlSettings ();
       void SetVideoControlSettings (BOOL Value);
       
       __int64 GetVideoDelay ();
       void SetVideoDelay (__int64 Value);
       
       int GetVideoFormat ();
       void SetVideoFormat (int Value);
       
       TFileSort GetVideoFromImages_BitmapsSortedBy ();
       void SetVideoFromImages_BitmapsSortedBy (TFileSort Value);
       
       BOOL GetVideoFromImages_RepeatIndefinitely ();
       void SetVideoFromImages_RepeatIndefinitely (BOOL Value);
       
       const wchar_t *GetVideoFromImages_SourceDirectory ();
       void SetVideoFromImages_SourceDirectory (const wchar_t *Value);
       
       const wchar_t *GetVideoFromImages_TemporaryFile ();
       void SetVideoFromImages_TemporaryFile (const wchar_t *Value);
       
       int GetVideoInput ();
       void SetVideoInput (int Value);
       
       int GetVideoProcessing_Brightness ();
       void SetVideoProcessing_Brightness (int Value);
       
       int GetVideoProcessing_Contrast ();
       void SetVideoProcessing_Contrast (int Value);
       
       TVideoDeinterlacing GetVideoProcessing_Deinterlacing ();
       void SetVideoProcessing_Deinterlacing (TVideoDeinterlacing Value);
       
       BOOL GetVideoProcessing_FlipHorizontal ();
       void SetVideoProcessing_FlipHorizontal (BOOL Value);
       
       BOOL GetVideoProcessing_FlipVertical ();
       void SetVideoProcessing_FlipVertical (BOOL Value);
       
       BOOL GetVideoProcessing_GrayScale ();
       void SetVideoProcessing_GrayScale (BOOL Value);
       
       int GetVideoProcessing_Hue ();
       void SetVideoProcessing_Hue (int Value);
       
       BOOL GetVideoProcessing_InvertColors ();
       void SetVideoProcessing_InvertColors (BOOL Value);
       
       int GetVideoProcessing_Pixellization ();
       void SetVideoProcessing_Pixellization (int Value);
       
       int GetVideoProcessing_Saturation ();
       void SetVideoProcessing_Saturation (int Value);
       
       TVideoRotation GetVideoProcessing_Rotation ();
       void SetVideoProcessing_Rotation (TVideoRotation Value);
       
       double GetVideoProcessing_RotationCustomAngle ();
       void SetVideoProcessing_RotationCustomAngle (double Value);
       
       BOOL GetVideoQualitySettings ();
       void SetVideoQualitySettings (BOOL Value);
       
       TVideoRenderer GetVideoRenderer ();
       void SetVideoRenderer (TVideoRenderer Value);
       
       TVideoRendererExternal GetVideoRendererExternal ();
       void SetVideoRendererExternal (TVideoRendererExternal Value);
       
       int GetVideoRendererExternalIndex ();
       void SetVideoRendererExternalIndex (int Value);
       
       TVideoRendererPriority GetVideoRendererPriority ();
       void SetVideoRendererPriority (TVideoRendererPriority Value);
       
       int GetVideoSize ();
       void SetVideoSize (int Value);
       
       TVideoSource GetVideoSource ();
       void SetVideoSource (TVideoSource Value);
       
       const wchar_t *GetVideoSource_FileOrURL ();
       void SetVideoSource_FileOrURL (const wchar_t *Value);
       
       __int64 GetVideoSource_FileOrURL_StartTime ();
       void SetVideoSource_FileOrURL_StartTime (__int64 Value);
       
       __int64 GetVideoSource_FileOrURL_StopTime ();
       void SetVideoSource_FileOrURL_StopTime (__int64 Value);
       
       const wchar_t *GetStreamInterface_Format ();
       void SetStreamInterface_Format (const wchar_t *Value);
       
       double GetStreamInterface_FrameRate ();
       void SetStreamInterface_FrameRate (double Value);
       
       BOOL GetStreamInterface_IsRealTime ();
       void SetStreamInterface_IsRealTime (BOOL Value);
       
       int GetVideoStreamNumber ();
       void SetVideoStreamNumber (int Value);
       
       int GetVideoSubtype ();
       void SetVideoSubtype (int Value);
       
       BOOL GetVideoVisibleWhenStopped ();
       void SetVideoVisibleWhenStopped (BOOL Value);
       
       int GetVirtualVideoStreamControl ();
       void SetVirtualVideoStreamControl (int Value);
       
       int GetVirtualAudioStreamControl ();
       void SetVirtualAudioStreamControl (int Value);
       
       TVuMeter GetVuMeter ();
       void SetVuMeter (TVuMeter Value);
       
       TWebcamStillCaptureButton GetWebcamStillCaptureButton ();
       void SetWebcamStillCaptureButton (TWebcamStillCaptureButton Value);
       
       int GetZoomCoeff ();
       void SetZoomCoeff (int Value);
       
       int GetZoomXCenter ();
       void SetZoomXCenter (int Value);
       
       int GetZoomYCenter ();
       void SetZoomYCenter (int Value);
       
    //#endregion DeclarePropertiesH
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
    //#region DeclareEventsH
       void SetOnAudioBufferNegotiation (TOnAudioBufferNegotiationCb OnAudioBufferNegotiationCb);
       void SetOnAudioDeviceSelected (TOnAudioDeviceSelectedCb OnAudioDeviceSelectedCb);
       void SetOnAudioPeak (TOnAudioPeakCb OnAudioPeakCb);
       void SetOnAuthenticationNeeded (TOnAuthenticationNeededCb OnAuthenticationNeededCb);
       void SetOnAVIDurationUpdated (TOnAVIDurationUpdatedCb OnAVIDurationUpdatedCb);
       void SetOnBacktimedFramesCountReached (TOnBacktimedFramesCountReachedCb OnBacktimedFramesCountReachedCb);
       void SetOnBitmapsLoadingProgress (TOnBitmapsLoadingProgressCb OnBitmapsLoadingProgressCb);
       void SetOnClick (TOnClickCb OnClickCb);
       void SetOnClientConnection (TOnClientConnectionCb OnClientConnectionCb);
       void SetOnColorKeyChange (TOnColorKeyChangeCb OnColorKeyChangeCb);
       void SetOnCopyPreallocDataCompleted (TOnCopyPreallocDataCompletedCb OnCopyPreallocDataCompletedCb);
       void SetOnCopyPreallocDataProgress (TOnCopyPreallocDataProgressCb OnCopyPreallocDataProgressCb);
       void SetOnCopyPreallocDataStarted (TOnCopyPreallocDataStartedCb OnCopyPreallocDataStartedCb);
       void SetOnCreatePreallocFileCompleted (TOnCreatePreallocFileCompletedCb OnCreatePreallocFileCompletedCb);
       void SetOnCreatePreallocFileProgress (TOnCreatePreallocFileProgressCb OnCreatePreallocFileProgressCb);
       void SetOnCreatePreallocFileStarted (TOnCreatePreallocFileStartedCb OnCreatePreallocFileStartedCb);
       void SetOnDblClick (TOnDblClickCb OnDblClickCb);
       void SetOnDeviceArrivalOrRemoval (TOnDeviceArrivalOrRemovalCb OnDeviceArrivalOrRemovalCb);
       void SetOnDeviceLost (TOnDeviceLostCb OnDeviceLostCb);
       void SetOnDeviceReconnected (TOnDeviceReconnectedCb OnDeviceReconnectedCb);
       void SetOnDeviceReconnecting (TOnDeviceReconnectingCb OnDeviceReconnectingCb);
       void SetOnDirectNetworkStreamingHostUrl (TOnDirectNetworkStreamingHostUrlCb OnDirectNetworkStreamingHostUrlCb);
       void SetOnDiskFull (TOnDiskFullCb OnDiskFullCb);
       void SetOnDragDrop (TOnDragDropCb OnDragDropCb);
       void SetOnDragDropFiles (TOnDragDropFilesCb OnDragDropFilesCb);
       void SetOnDragOver (TOnDragOverCb OnDragOverCb);
       void SetOnDVCommandCompleted (TOnDVCommandCompletedCb OnDVCommandCompletedCb);
       void SetOnDVDiscontinuity (TOnDVDiscontinuityCb OnDVDiscontinuityCb);
       void SetOnEnumerateWindows (TOnEnumerateWindowsCb OnEnumerateWindowsCb);
       void SetOnFilterSelected (TOnFilterSelectedCb OnFilterSelectedCb);
       void SetOnFirstFrameReceived (TOnFirstFrameReceivedCb OnFirstFrameReceivedCb);
       void SetOnFrameBitmap (TOnFrameBitmapCb OnFrameBitmapCb);
       void SetOnFrameCaptureCompleted (TOnFrameCaptureCompletedCb OnFrameCaptureCompletedCb);
       void SetOnFrameOverlayUsingDC (TOnFrameOverlayUsingDCCb OnFrameOverlayUsingDCCb);
       void SetOnFrameOverlayUsingDIB (TOnFrameOverlayUsingDIBCb OnFrameOverlayUsingDIBCb);
       void SetOnFrameProgress (TOnFrameProgressCb OnFrameProgressCb);
       void SetOnFrameProgress2 (TOnFrameProgress2Cb OnFrameProgress2Cb);
       void SetOnGraphBuilt (TOnGraphBuiltCb OnGraphBuiltCb);
       void SetOnInactive (TOnInactiveCb OnInactiveCb);
       void SetOnKeyPress (TOnKeyPressCb OnKeyPressCb);
       void SetOnLastCommandCompleted (TOnLastCommandCompletedCb OnLastCommandCompletedCb);
       void SetOnLeavingFullScreen (TOnLeavingFullScreenCb OnLeavingFullScreenCb);
       void SetOnLog (TOnLogCb OnLogCb);
       void SetOnMotionDetected (TOnMotionDetectedCb OnMotionDetectedCb);
       void SetOnMotionNotDetected (TOnMotionNotDetectedCb OnMotionNotDetectedCb);
       void SetOnMouseDown (TOnMouseDownCb OnMouseDownCb);
       void SetOnMouseDown_Video (TOnMouseDown_VideoCb OnMouseDown_VideoCb);
       void SetOnMouseDown_Window (TOnMouseDown_WindowCb OnMouseDown_WindowCb);
       void SetOnMouseEnter (TOnMouseEnterCb OnMouseEnterCb);
       void SetOnMouseLeave (TOnMouseLeaveCb OnMouseLeaveCb);
       void SetOnMouseMove (TOnMouseMoveCb OnMouseMoveCb);
       void SetOnMouseMove_Video (TOnMouseMove_VideoCb OnMouseMove_VideoCb);
       void SetOnMouseMove_Window (TOnMouseMove_WindowCb OnMouseMove_WindowCb);
       void SetOnMouseUp (TOnMouseUpCb OnMouseUpCb);
       void SetOnMouseUp_Video (TOnMouseUp_VideoCb OnMouseUp_VideoCb);
       void SetOnMouseUp_Window (TOnMouseUp_WindowCb OnMouseUp_WindowCb);
       void SetOnMouseWheel (TOnMouseWheelCb OnMouseWheelCb);
       void SetOnMultipurposeEncoderCompleted (TOnMultipurposeEncoderCompletedCb OnMultipurposeEncoderCompletedCb);
       void SetOnMultipurposeEncoderError (TOnMultipurposeEncoderErrorCb OnMultipurposeEncoderErrorCb);
       void SetOnMultipurposeEncoderProgress (TOnMultipurposeEncoderProgressCb OnMultipurposeEncoderProgressCb);
       void SetOnNoVideoDevices (TOnNoVideoDevicesCb OnNoVideoDevicesCb);
       void SetOnNTPTimeStamp (TOnNTPTimeStampCb OnNTPTimeStampCb);
       void SetOnPlayerBufferingData (TOnPlayerBufferingDataCb OnPlayerBufferingDataCb);
       void SetOnPlayerDurationUpdated (TOnPlayerDurationUpdatedCb OnPlayerDurationUpdatedCb);
       void SetOnPlayerEndOfPlaylist (TOnPlayerEndOfPlaylistCb OnPlayerEndOfPlaylistCb);
       void SetOnPlayerEndOfStream (TOnPlayerEndOfStreamCb OnPlayerEndOfStreamCb);
       void SetOnPlayerOpened (TOnPlayerOpenedCb OnPlayerOpenedCb);
       void SetOnPlayerStateChanged (TOnPlayerStateChangedCb OnPlayerStateChangedCb);
       void SetOnPlayerUpdateTrackbarPosition (TOnPlayerUpdateTrackbarPositionCb OnPlayerUpdateTrackbarPositionCb);
       void SetOnPreviewStarted (TOnPreviewStartedCb OnPreviewStartedCb);
       void SetOnRawAudioSample (TOnRawAudioSampleCb OnRawAudioSampleCb);
       void SetOnRawVideoSample (TOnRawVideoSampleCb OnRawVideoSampleCb);
       void SetOnRecordingCompleted (TOnRecordingCompletedCb OnRecordingCompletedCb);
       void SetOnRecordingPaused (TOnRecordingPausedCb OnRecordingPausedCb);
       void SetOnRecordingReadyToStart (TOnRecordingReadyToStartCb OnRecordingReadyToStartCb);
       void SetOnRecordingStarted (TOnRecordingStartedCb OnRecordingStartedCb);
       void SetOnReencodingCompleted (TOnReencodingCompletedCb OnReencodingCompletedCb);
       void SetOnReencodingProgress (TOnReencodingProgressCb OnReencodingProgressCb);
       void SetOnReencodingStarted (TOnReencodingStartedCb OnReencodingStartedCb);
       void SetOnReinitializing (TOnReinitializingCb OnReinitializingCb);
       void SetOnResizeVideo (TOnResizeVideoCb OnResizeVideoCb);
       void SetOnStoppingGraph (TOnStoppingGraphCb OnStoppingGraphCb);
       void SetOnStoppingGraphCompleted (TOnStoppingGraphCompletedCb OnStoppingGraphCompletedCb);
       void SetOnTextOverlayScrollingCompleted (TOnTextOverlayScrollingCompletedCb OnTextOverlayScrollingCompletedCb);
       void SetOnThirdPartyFilterAdded (TOnThirdPartyFilterAddedCb OnThirdPartyFilterAddedCb);
       void SetOnThirdPartyFilterConnected (TOnThirdPartyFilterConnectedCb OnThirdPartyFilterConnectedCb);
       void SetOnThirdPartyFilterConnected2 (TOnThirdPartyFilterConnected2Cb OnThirdPartyFilterConnected2Cb);
       void SetOnThreadSync (TOnThreadSyncCb OnThreadSyncCb);
       void SetOnTVChannelScanCompleted (TOnTVChannelScanCompletedCb OnTVChannelScanCompletedCb);
       void SetOnTVChannelScanStarted (TOnTVChannelScanStartedCb OnTVChannelScanStartedCb);
       void SetOnTVChannelSelected (TOnTVChannelSelectedCb OnTVChannelSelectedCb);
       void SetOnVideoCompressionSettings (TOnVideoCompressionSettingsCb OnVideoCompressionSettingsCb);
       void SetOnVideoDeviceSelected (TOnVideoDeviceSelectedCb OnVideoDeviceSelectedCb);
       void SetOnVideoFromBitmapsNextFrameNeeded (TOnVideoFromBitmapsNextFrameNeededCb OnVideoFromBitmapsNextFrameNeededCb);
    //#endregion DeclareEventsH
};

#endif
