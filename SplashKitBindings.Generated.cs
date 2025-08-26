using System.Runtime.InteropServices.JavaScript; 

namespace SplashKitSDK 
{
   public partial class AnimationScript
   {
      [JSImport("SplashKitBackendWASM.animation_count", "main.js")] 
      public partial int AnimationCount;

      [JSImport("SplashKitBackendWASM.animation_index", "main.js")] 
      public partial int AnimationIndex(string name);

      [JSImport("SplashKitBackendWASM.animation_script_name", "main.js")] 
      public partial string Name;

      [JSImport("SplashKitBackendWASM.create_animation", "main.js")] 
      public partial Animation CreateAnimation(string name);

      [JSImport("SplashKitBackendWASM.create_animation", "main.js")] 
      public partial Animation CreateAnimation(string name, bool withSound);

      [JSImport("SplashKitBackendWASM.free_animation_script", "main.js")] 
      public partial void Free();

     } 

   public partial class SplashKit
   {
      [JSImport("SplashKitBackendWASM.animation_count", "main.js")] 
      public static partial int AnimationCount(AnimationScript script);

      [JSImport("SplashKitBackendWASM.animation_current_cell", "main.js")] 
      public static partial int AnimationCurrentCell(Animation anim);

      [JSImport("SplashKitBackendWASM.animation_current_vector", "main.js")] 
      public static partial Vector2D AnimationCurrentVector(Animation anim);

      [JSImport("SplashKitBackendWASM.animation_ended", "main.js")] 
      public static partial bool AnimationEnded(Animation anim);

      [JSImport("SplashKitBackendWASM.animation_entered_frame", "main.js")] 
      public static partial bool AnimationEnteredFrame(Animation anim);

      [JSImport("SplashKitBackendWASM.animation_frame_time", "main.js")] 
      public static partial float AnimationFrameTime(Animation anim);

      [JSImport("SplashKitBackendWASM.animation_index", "main.js")] 
      public static partial int AnimationIndex(AnimationScript script, string name);

      [JSImport("SplashKitBackendWASM.animation_name", "main.js")] 
      public static partial string AnimationName(Animation temp);

      [JSImport("SplashKitBackendWASM.animation_script_name", "main.js")] 
      public static partial string AnimationScriptName(AnimationScript script);

      [JSImport("SplashKitBackendWASM.animation_script_named", "main.js")] 
      public static partial AnimationScript AnimationScriptNamed(string name);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, AnimationScript script, string name);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, AnimationScript script, string name, bool withSound);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, AnimationScript script, int idx);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, AnimationScript script, int idx, bool withSound);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, string scriptName, string name);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, string scriptName, string name, bool withSound);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, int idx);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, int idx, bool withSound);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, string name);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public static partial void AssignAnimation(Animation anim, string name, bool withSound);

      [JSImport("SplashKitBackendWASM.create_animation", "main.js")] 
      public static partial Animation CreateAnimation(AnimationScript script, int idx, bool withSound);

      [JSImport("SplashKitBackendWASM.create_animation", "main.js")] 
      public static partial Animation CreateAnimation(AnimationScript script, string name);

      [JSImport("SplashKitBackendWASM.create_animation", "main.js")] 
      public static partial Animation CreateAnimation(AnimationScript script, string name, bool withSound);

      [JSImport("SplashKitBackendWASM.create_animation", "main.js")] 
      public static partial Animation CreateAnimation(string scriptName, string name);

      [JSImport("SplashKitBackendWASM.create_animation", "main.js")] 
      public static partial Animation CreateAnimation(string scriptName, string name, bool withSound);

      [JSImport("SplashKitBackendWASM.free_all_animation_scripts", "main.js")] 
      public static partial void FreeAllAnimationScripts();

      [JSImport("SplashKitBackendWASM.free_animation", "main.js")] 
      public static partial void FreeAnimation(Animation ani);

      [JSImport("SplashKitBackendWASM.free_animation_script", "main.js")] 
      public static partial void FreeAnimationScript(AnimationScript scriptToFree);

      [JSImport("SplashKitBackendWASM.free_animation_script", "main.js")] 
      public static partial void FreeAnimationScript(string name);

      [JSImport("SplashKitBackendWASM.has_animation_named", "main.js")] 
      public static partial bool HasAnimationNamed(AnimationScript script, string name);

      [JSImport("SplashKitBackendWASM.has_animation_script", "main.js")] 
      public static partial bool HasAnimationScript(string name);

      [JSImport("SplashKitBackendWASM.load_animation_script", "main.js")] 
      public static partial AnimationScript LoadAnimationScript(string name, string filename);

      [JSImport("SplashKitBackendWASM.restart_animation", "main.js")] 
      public static partial void RestartAnimation(Animation anim);

      [JSImport("SplashKitBackendWASM.restart_animation", "main.js")] 
      public static partial void RestartAnimation(Animation anim, bool withSound);

      [JSImport("SplashKitBackendWASM.update_animation", "main.js")] 
      public static partial void UpdateAnimation(Animation anim, float pct, bool withSound);

      [JSImport("SplashKitBackendWASM.update_animation", "main.js")] 
      public static partial void UpdateAnimation(Animation anim);

      [JSImport("SplashKitBackendWASM.update_animation", "main.js")] 
      public static partial void UpdateAnimation(Animation anim, float pct);

      [JSImport("SplashKitBackendWASM.audio_ready", "main.js")] 
      public static partial bool AudioReady();

      [JSImport("SplashKitBackendWASM.close_audio", "main.js")] 
      public static partial void CloseAudio();

      [JSImport("SplashKitBackendWASM.open_audio", "main.js")] 
      public static partial void OpenAudio();

      [JSImport("SplashKitBackendWASM.fade_music_in", "main.js")] 
      public static partial void FadeMusicIn(string name, int ms);

      [JSImport("SplashKitBackendWASM.fade_music_in", "main.js")] 
      public static partial void FadeMusicIn(string name, int times, int ms);

      [JSImport("SplashKitBackendWASM.fade_music_in", "main.js")] 
      public static partial void FadeMusicIn(Music data, int ms);

      [JSImport("SplashKitBackendWASM.fade_music_in", "main.js")] 
      public static partial void FadeMusicIn(Music data, int times, int ms);

      [JSImport("SplashKitBackendWASM.fade_music_out", "main.js")] 
      public static partial void FadeMusicOut(int ms);

      [JSImport("SplashKitBackendWASM.free_all_music", "main.js")] 
      public static partial void FreeAllMusic();

      [JSImport("SplashKitBackendWASM.free_music", "main.js")] 
      public static partial void FreeMusic(Music effect);

      [JSImport("SplashKitBackendWASM.has_music", "main.js")] 
      public static partial bool HasMusic(string name);

      [JSImport("SplashKitBackendWASM.load_music", "main.js")] 
      public static partial Music LoadMusic(string name, string filename);

      [JSImport("SplashKitBackendWASM.music_filename", "main.js")] 
      public static partial string MusicFilename(Music data);

      [JSImport("SplashKitBackendWASM.music_name", "main.js")] 
      public static partial string MusicName(Music data);

      [JSImport("SplashKitBackendWASM.music_named", "main.js")] 
      public static partial Music MusicNamed(string name);

      [JSImport("SplashKitBackendWASM.music_playing", "main.js")] 
      public static partial bool MusicPlaying();

      [JSImport("SplashKitBackendWASM.music_valid", "main.js")] 
      public static partial bool MusicValid(Music m);

      [JSImport("SplashKitBackendWASM.music_volume", "main.js")] 
      public static partial double MusicVolume();

      [JSImport("SplashKitBackendWASM.pause_music", "main.js")] 
      public static partial void PauseMusic();

      [JSImport("SplashKitBackendWASM.play_music", "main.js")] 
      public static partial void PlayMusic(string name);

      [JSImport("SplashKitBackendWASM.play_music", "main.js")] 
      public static partial void PlayMusic(string name, int times);

      [JSImport("SplashKitBackendWASM.play_music", "main.js")] 
      public static partial void PlayMusic(Music data);

      [JSImport("SplashKitBackendWASM.play_music", "main.js")] 
      public static partial void PlayMusic(Music data, int times);

      [JSImport("SplashKitBackendWASM.play_music", "main.js")] 
      public static partial void PlayMusic(Music data, int times, double volume);

      [JSImport("SplashKitBackendWASM.resume_music", "main.js")] 
      public static partial void ResumeMusic();

      [JSImport("SplashKitBackendWASM.set_music_volume", "main.js")] 
      public static partial void SetMusicVolume(double volume);

      [JSImport("SplashKitBackendWASM.stop_music", "main.js")] 
      public static partial void StopMusic();

      [JSImport("SplashKitBackendWASM.fade_all_sound_effects_out", "main.js")] 
      public static partial void FadeAllSoundEffectsOut(int ms);

      [JSImport("SplashKitBackendWASM.fade_sound_effect_out", "main.js")] 
      public static partial void FadeSoundEffectOut(SoundEffect effect, int ms);

      [JSImport("SplashKitBackendWASM.free_all_sound_effects", "main.js")] 
      public static partial void FreeAllSoundEffects();

      [JSImport("SplashKitBackendWASM.free_sound_effect", "main.js")] 
      public static partial void FreeSoundEffect(SoundEffect effect);

      [JSImport("SplashKitBackendWASM.has_sound_effect", "main.js")] 
      public static partial bool HasSoundEffect(string name);

      [JSImport("SplashKitBackendWASM.load_sound_effect", "main.js")] 
      public static partial SoundEffect LoadSoundEffect(string name, string filename);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public static partial void PlaySoundEffect(string name);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public static partial void PlaySoundEffect(string name, double volume);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public static partial void PlaySoundEffect(string name, int times);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public static partial void PlaySoundEffect(string name, int times, double volume);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public static partial void PlaySoundEffect(SoundEffect effect);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public static partial void PlaySoundEffect(SoundEffect effect, double volume);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public static partial void PlaySoundEffect(SoundEffect effect, int times);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public static partial void PlaySoundEffect(SoundEffect effect, int times, double volume);

      [JSImport("SplashKitBackendWASM.sound_effect_filename", "main.js")] 
      public static partial string SoundEffectFilename(SoundEffect effect);

      [JSImport("SplashKitBackendWASM.sound_effect_name", "main.js")] 
      public static partial string SoundEffectName(SoundEffect effect);

      [JSImport("SplashKitBackendWASM.sound_effect_named", "main.js")] 
      public static partial SoundEffect SoundEffectNamed(string name);

      [JSImport("SplashKitBackendWASM.sound_effect_playing", "main.js")] 
      public static partial bool SoundEffectPlaying(string name);

      [JSImport("SplashKitBackendWASM.sound_effect_playing", "main.js")] 
      public static partial bool SoundEffectPlaying(SoundEffect effect);

      [JSImport("SplashKitBackendWASM.sound_effect_valid", "main.js")] 
      public static partial bool SoundEffectValid(SoundEffect effect);

      [JSImport("SplashKitBackendWASM.stop_sound_effect", "main.js")] 
      public static partial void StopSoundEffect(string name);

      [JSImport("SplashKitBackendWASM.stop_sound_effect", "main.js")] 
      public static partial void StopSoundEffect(SoundEffect effect);

      [JSImport("SplashKitBackendWASM.camera_position", "main.js")] 
      public static partial Point2D CameraPosition();

      [JSImport("SplashKitBackendWASM.camera_x", "main.js")] 
      public static partial double CameraX();

      [JSImport("SplashKitBackendWASM.camera_y", "main.js")] 
      public static partial double CameraY();

      [JSImport("SplashKitBackendWASM.center_camera_on", "main.js")] 
      public static partial void CenterCameraOn(Sprite s, Vector2D offset);

      [JSImport("SplashKitBackendWASM.center_camera_on", "main.js")] 
      public static partial void CenterCameraOn(Sprite s, double offsetX, double offsetY);

      [JSImport("SplashKitBackendWASM.move_camera_by", "main.js")] 
      public static partial void MoveCameraBy(Vector2D offset);

      [JSImport("SplashKitBackendWASM.move_camera_by", "main.js")] 
      public static partial void MoveCameraBy(double dx, double dy);

      [JSImport("SplashKitBackendWASM.move_camera_to", "main.js")] 
      public static partial void MoveCameraTo(Point2D pt);

      [JSImport("SplashKitBackendWASM.move_camera_to", "main.js")] 
      public static partial void MoveCameraTo(double x, double y);

      [JSImport("SplashKitBackendWASM.point_in_window", "main.js")] 
      public static partial bool PointInWindow(Window wind, Point2D pt);

      [JSImport("SplashKitBackendWASM.point_on_screen", "main.js")] 
      public static partial bool PointOnScreen(Point2D pt);

      [JSImport("SplashKitBackendWASM.rect_in_window", "main.js")] 
      public static partial bool RectInWindow(Window wind, Rectangle rect);

      [JSImport("SplashKitBackendWASM.rect_on_screen", "main.js")] 
      public static partial bool RectOnScreen(Rectangle rect);

      [JSImport("SplashKitBackendWASM.screen_center", "main.js")] 
      public static partial Point2D ScreenCenter();

      [JSImport("SplashKitBackendWASM.screen_rectangle", "main.js")] 
      public static partial Rectangle ScreenRectangle();

      [JSImport("SplashKitBackendWASM.set_camera_position", "main.js")] 
      public static partial void SetCameraPosition(Point2D pos);

      [JSImport("SplashKitBackendWASM.set_camera_x", "main.js")] 
      public static partial void SetCameraX(double x);

      [JSImport("SplashKitBackendWASM.set_camera_y", "main.js")] 
      public static partial void SetCameraY(double y);

      [JSImport("SplashKitBackendWASM.to_screen", "main.js")] 
      public static partial Point2D ToScreen(Point2D pt);

      [JSImport("SplashKitBackendWASM.to_screen", "main.js")] 
      public static partial Rectangle ToScreen(Rectangle rect);

      [JSImport("SplashKitBackendWASM.to_screen_x", "main.js")] 
      public static partial double ToScreenX(double worldX);

      [JSImport("SplashKitBackendWASM.to_screen_y", "main.js")] 
      public static partial double ToScreenY(double worldY);

      [JSImport("SplashKitBackendWASM.to_world", "main.js")] 
      public static partial Point2D ToWorld(Point2D pt);

      [JSImport("SplashKitBackendWASM.to_world_x", "main.js")] 
      public static partial double ToWorldX(double screenX);

      [JSImport("SplashKitBackendWASM.to_world_y", "main.js")] 
      public static partial double ToWorldY(double screenY);

      [JSImport("SplashKitBackendWASM.vector_world_to_screen", "main.js")] 
      public static partial Vector2D VectorWorldToScreen();

      [JSImport("SplashKitBackendWASM.window_area", "main.js")] 
      public static partial Rectangle WindowArea(Window wind);

      [JSImport("SplashKitBackendWASM.alpha_of", "main.js")] 
      public static partial int AlphaOf(Color c);

      [JSImport("SplashKitBackendWASM.blue_of", "main.js")] 
      public static partial int BlueOf(Color c);

      [JSImport("SplashKitBackendWASM.brightness_of", "main.js")] 
      public static partial double BrightnessOf(Color c);

      [JSImport("SplashKitBackendWASM.color_alice_blue", "main.js")] 
      public static partial Color ColorAliceBlue();

      [JSImport("SplashKitBackendWASM.color_antique_white", "main.js")] 
      public static partial Color ColorAntiqueWhite();

      [JSImport("SplashKitBackendWASM.color_aqua", "main.js")] 
      public static partial Color ColorAqua();

      [JSImport("SplashKitBackendWASM.color_aquamarine", "main.js")] 
      public static partial Color ColorAquamarine();

      [JSImport("SplashKitBackendWASM.color_azure", "main.js")] 
      public static partial Color ColorAzure();

      [JSImport("SplashKitBackendWASM.color_beige", "main.js")] 
      public static partial Color ColorBeige();

      [JSImport("SplashKitBackendWASM.color_bisque", "main.js")] 
      public static partial Color ColorBisque();

      [JSImport("SplashKitBackendWASM.color_black", "main.js")] 
      public static partial Color ColorBlack();

      [JSImport("SplashKitBackendWASM.color_blanched_almond", "main.js")] 
      public static partial Color ColorBlanchedAlmond();

      [JSImport("SplashKitBackendWASM.color_blue", "main.js")] 
      public static partial Color ColorBlue();

      [JSImport("SplashKitBackendWASM.color_blue_violet", "main.js")] 
      public static partial Color ColorBlueViolet();

      [JSImport("SplashKitBackendWASM.color_bright_green", "main.js")] 
      public static partial Color ColorBrightGreen();

      [JSImport("SplashKitBackendWASM.color_brown", "main.js")] 
      public static partial Color ColorBrown();

      [JSImport("SplashKitBackendWASM.color_burly_wood", "main.js")] 
      public static partial Color ColorBurlyWood();

      [JSImport("SplashKitBackendWASM.color_cadet_blue", "main.js")] 
      public static partial Color ColorCadetBlue();

      [JSImport("SplashKitBackendWASM.color_chartreuse", "main.js")] 
      public static partial Color ColorChartreuse();

      [JSImport("SplashKitBackendWASM.color_chocolate", "main.js")] 
      public static partial Color ColorChocolate();

      [JSImport("SplashKitBackendWASM.color_coral", "main.js")] 
      public static partial Color ColorCoral();

      [JSImport("SplashKitBackendWASM.color_cornflower_blue", "main.js")] 
      public static partial Color ColorCornflowerBlue();

      [JSImport("SplashKitBackendWASM.color_cornsilk", "main.js")] 
      public static partial Color ColorCornsilk();

      [JSImport("SplashKitBackendWASM.color_crimson", "main.js")] 
      public static partial Color ColorCrimson();

      [JSImport("SplashKitBackendWASM.color_cyan", "main.js")] 
      public static partial Color ColorCyan();

      [JSImport("SplashKitBackendWASM.color_dark_blue", "main.js")] 
      public static partial Color ColorDarkBlue();

      [JSImport("SplashKitBackendWASM.color_dark_cyan", "main.js")] 
      public static partial Color ColorDarkCyan();

      [JSImport("SplashKitBackendWASM.color_dark_goldenrod", "main.js")] 
      public static partial Color ColorDarkGoldenrod();

      [JSImport("SplashKitBackendWASM.color_dark_gray", "main.js")] 
      public static partial Color ColorDarkGray();

      [JSImport("SplashKitBackendWASM.color_dark_green", "main.js")] 
      public static partial Color ColorDarkGreen();

      [JSImport("SplashKitBackendWASM.color_dark_khaki", "main.js")] 
      public static partial Color ColorDarkKhaki();

      [JSImport("SplashKitBackendWASM.color_dark_magenta", "main.js")] 
      public static partial Color ColorDarkMagenta();

      [JSImport("SplashKitBackendWASM.color_dark_olive_green", "main.js")] 
      public static partial Color ColorDarkOliveGreen();

      [JSImport("SplashKitBackendWASM.color_dark_orange", "main.js")] 
      public static partial Color ColorDarkOrange();

      [JSImport("SplashKitBackendWASM.color_dark_orchid", "main.js")] 
      public static partial Color ColorDarkOrchid();

      [JSImport("SplashKitBackendWASM.color_dark_red", "main.js")] 
      public static partial Color ColorDarkRed();

      [JSImport("SplashKitBackendWASM.color_dark_salmon", "main.js")] 
      public static partial Color ColorDarkSalmon();

      [JSImport("SplashKitBackendWASM.color_dark_sea_green", "main.js")] 
      public static partial Color ColorDarkSeaGreen();

      [JSImport("SplashKitBackendWASM.color_dark_slate_blue", "main.js")] 
      public static partial Color ColorDarkSlateBlue();

      [JSImport("SplashKitBackendWASM.color_dark_slate_gray", "main.js")] 
      public static partial Color ColorDarkSlateGray();

      [JSImport("SplashKitBackendWASM.color_dark_turquoise", "main.js")] 
      public static partial Color ColorDarkTurquoise();

      [JSImport("SplashKitBackendWASM.color_dark_violet", "main.js")] 
      public static partial Color ColorDarkViolet();

      [JSImport("SplashKitBackendWASM.color_deep_pink", "main.js")] 
      public static partial Color ColorDeepPink();

      [JSImport("SplashKitBackendWASM.color_deep_sky_blue", "main.js")] 
      public static partial Color ColorDeepSkyBlue();

      [JSImport("SplashKitBackendWASM.color_dim_gray", "main.js")] 
      public static partial Color ColorDimGray();

      [JSImport("SplashKitBackendWASM.color_dodger_blue", "main.js")] 
      public static partial Color ColorDodgerBlue();

      [JSImport("SplashKitBackendWASM.color_firebrick", "main.js")] 
      public static partial Color ColorFirebrick();

      [JSImport("SplashKitBackendWASM.color_floral_white", "main.js")] 
      public static partial Color ColorFloralWhite();

      [JSImport("SplashKitBackendWASM.color_forest_green", "main.js")] 
      public static partial Color ColorForestGreen();

      [JSImport("SplashKitBackendWASM.color_fuchsia", "main.js")] 
      public static partial Color ColorFuchsia();

      [JSImport("SplashKitBackendWASM.color_gainsboro", "main.js")] 
      public static partial Color ColorGainsboro();

      [JSImport("SplashKitBackendWASM.color_ghost_white", "main.js")] 
      public static partial Color ColorGhostWhite();

      [JSImport("SplashKitBackendWASM.color_gold", "main.js")] 
      public static partial Color ColorGold();

      [JSImport("SplashKitBackendWASM.color_goldenrod", "main.js")] 
      public static partial Color ColorGoldenrod();

      [JSImport("SplashKitBackendWASM.color_gray", "main.js")] 
      public static partial Color ColorGray();

      [JSImport("SplashKitBackendWASM.color_green", "main.js")] 
      public static partial Color ColorGreen();

      [JSImport("SplashKitBackendWASM.color_green_yellow", "main.js")] 
      public static partial Color ColorGreenYellow();

      [JSImport("SplashKitBackendWASM.color_honeydew", "main.js")] 
      public static partial Color ColorHoneydew();

      [JSImport("SplashKitBackendWASM.color_hot_pink", "main.js")] 
      public static partial Color ColorHotPink();

      [JSImport("SplashKitBackendWASM.color_indian_red", "main.js")] 
      public static partial Color ColorIndianRed();

      [JSImport("SplashKitBackendWASM.color_indigo", "main.js")] 
      public static partial Color ColorIndigo();

      [JSImport("SplashKitBackendWASM.color_ivory", "main.js")] 
      public static partial Color ColorIvory();

      [JSImport("SplashKitBackendWASM.color_khaki", "main.js")] 
      public static partial Color ColorKhaki();

      [JSImport("SplashKitBackendWASM.color_lavender", "main.js")] 
      public static partial Color ColorLavender();

      [JSImport("SplashKitBackendWASM.color_lavender_blush", "main.js")] 
      public static partial Color ColorLavenderBlush();

      [JSImport("SplashKitBackendWASM.color_lawn_green", "main.js")] 
      public static partial Color ColorLawnGreen();

      [JSImport("SplashKitBackendWASM.color_lemon_chiffon", "main.js")] 
      public static partial Color ColorLemonChiffon();

      [JSImport("SplashKitBackendWASM.color_light_blue", "main.js")] 
      public static partial Color ColorLightBlue();

      [JSImport("SplashKitBackendWASM.color_light_coral", "main.js")] 
      public static partial Color ColorLightCoral();

      [JSImport("SplashKitBackendWASM.color_light_cyan", "main.js")] 
      public static partial Color ColorLightCyan();

      [JSImport("SplashKitBackendWASM.color_light_goldenrod_yellow", "main.js")] 
      public static partial Color ColorLightGoldenrodYellow();

      [JSImport("SplashKitBackendWASM.color_light_gray", "main.js")] 
      public static partial Color ColorLightGray();

      [JSImport("SplashKitBackendWASM.color_light_green", "main.js")] 
      public static partial Color ColorLightGreen();

      [JSImport("SplashKitBackendWASM.color_light_pink", "main.js")] 
      public static partial Color ColorLightPink();

      [JSImport("SplashKitBackendWASM.color_light_salmon", "main.js")] 
      public static partial Color ColorLightSalmon();

      [JSImport("SplashKitBackendWASM.color_light_sea_green", "main.js")] 
      public static partial Color ColorLightSeaGreen();

      [JSImport("SplashKitBackendWASM.color_light_sky_blue", "main.js")] 
      public static partial Color ColorLightSkyBlue();

      [JSImport("SplashKitBackendWASM.color_light_slate_gray", "main.js")] 
      public static partial Color ColorLightSlateGray();

      [JSImport("SplashKitBackendWASM.color_light_steel_blue", "main.js")] 
      public static partial Color ColorLightSteelBlue();

      [JSImport("SplashKitBackendWASM.color_light_yellow", "main.js")] 
      public static partial Color ColorLightYellow();

      [JSImport("SplashKitBackendWASM.color_lime", "main.js")] 
      public static partial Color ColorLime();

      [JSImport("SplashKitBackendWASM.color_lime_green", "main.js")] 
      public static partial Color ColorLimeGreen();

      [JSImport("SplashKitBackendWASM.color_linen", "main.js")] 
      public static partial Color ColorLinen();

      [JSImport("SplashKitBackendWASM.color_magenta", "main.js")] 
      public static partial Color ColorMagenta();

      [JSImport("SplashKitBackendWASM.color_maroon", "main.js")] 
      public static partial Color ColorMaroon();

      [JSImport("SplashKitBackendWASM.color_medium_aquamarine", "main.js")] 
      public static partial Color ColorMediumAquamarine();

      [JSImport("SplashKitBackendWASM.color_medium_blue", "main.js")] 
      public static partial Color ColorMediumBlue();

      [JSImport("SplashKitBackendWASM.color_medium_orchid", "main.js")] 
      public static partial Color ColorMediumOrchid();

      [JSImport("SplashKitBackendWASM.color_medium_purple", "main.js")] 
      public static partial Color ColorMediumPurple();

      [JSImport("SplashKitBackendWASM.color_medium_sea_green", "main.js")] 
      public static partial Color ColorMediumSeaGreen();

      [JSImport("SplashKitBackendWASM.color_medium_slate_blue", "main.js")] 
      public static partial Color ColorMediumSlateBlue();

      [JSImport("SplashKitBackendWASM.color_medium_spring_green", "main.js")] 
      public static partial Color ColorMediumSpringGreen();

      [JSImport("SplashKitBackendWASM.color_medium_turquoise", "main.js")] 
      public static partial Color ColorMediumTurquoise();

      [JSImport("SplashKitBackendWASM.color_medium_violet_red", "main.js")] 
      public static partial Color ColorMediumVioletRed();

      [JSImport("SplashKitBackendWASM.color_midnight_blue", "main.js")] 
      public static partial Color ColorMidnightBlue();

      [JSImport("SplashKitBackendWASM.color_mint_cream", "main.js")] 
      public static partial Color ColorMintCream();

      [JSImport("SplashKitBackendWASM.color_misty_rose", "main.js")] 
      public static partial Color ColorMistyRose();

      [JSImport("SplashKitBackendWASM.color_moccasin", "main.js")] 
      public static partial Color ColorMoccasin();

      [JSImport("SplashKitBackendWASM.color_navajo_white", "main.js")] 
      public static partial Color ColorNavajoWhite();

      [JSImport("SplashKitBackendWASM.color_navy", "main.js")] 
      public static partial Color ColorNavy();

      [JSImport("SplashKitBackendWASM.color_old_lace", "main.js")] 
      public static partial Color ColorOldLace();

      [JSImport("SplashKitBackendWASM.color_olive", "main.js")] 
      public static partial Color ColorOlive();

      [JSImport("SplashKitBackendWASM.color_olive_drab", "main.js")] 
      public static partial Color ColorOliveDrab();

      [JSImport("SplashKitBackendWASM.color_orange", "main.js")] 
      public static partial Color ColorOrange();

      [JSImport("SplashKitBackendWASM.color_orange_red", "main.js")] 
      public static partial Color ColorOrangeRed();

      [JSImport("SplashKitBackendWASM.color_orchid", "main.js")] 
      public static partial Color ColorOrchid();

      [JSImport("SplashKitBackendWASM.color_pale_goldenrod", "main.js")] 
      public static partial Color ColorPaleGoldenrod();

      [JSImport("SplashKitBackendWASM.color_pale_green", "main.js")] 
      public static partial Color ColorPaleGreen();

      [JSImport("SplashKitBackendWASM.color_pale_turquoise", "main.js")] 
      public static partial Color ColorPaleTurquoise();

      [JSImport("SplashKitBackendWASM.color_pale_violet_red", "main.js")] 
      public static partial Color ColorPaleVioletRed();

      [JSImport("SplashKitBackendWASM.color_papaya_whip", "main.js")] 
      public static partial Color ColorPapayaWhip();

      [JSImport("SplashKitBackendWASM.color_peach_puff", "main.js")] 
      public static partial Color ColorPeachPuff();

      [JSImport("SplashKitBackendWASM.color_peru", "main.js")] 
      public static partial Color ColorPeru();

      [JSImport("SplashKitBackendWASM.color_pink", "main.js")] 
      public static partial Color ColorPink();

      [JSImport("SplashKitBackendWASM.color_plum", "main.js")] 
      public static partial Color ColorPlum();

      [JSImport("SplashKitBackendWASM.color_powder_blue", "main.js")] 
      public static partial Color ColorPowderBlue();

      [JSImport("SplashKitBackendWASM.color_purple", "main.js")] 
      public static partial Color ColorPurple();

      [JSImport("SplashKitBackendWASM.color_red", "main.js")] 
      public static partial Color ColorRed();

      [JSImport("SplashKitBackendWASM.color_rosy_brown", "main.js")] 
      public static partial Color ColorRosyBrown();

      [JSImport("SplashKitBackendWASM.color_royal_blue", "main.js")] 
      public static partial Color ColorRoyalBlue();

      [JSImport("SplashKitBackendWASM.color_saddle_brown", "main.js")] 
      public static partial Color ColorSaddleBrown();

      [JSImport("SplashKitBackendWASM.color_salmon", "main.js")] 
      public static partial Color ColorSalmon();

      [JSImport("SplashKitBackendWASM.color_sandy_brown", "main.js")] 
      public static partial Color ColorSandyBrown();

      [JSImport("SplashKitBackendWASM.color_sea_green", "main.js")] 
      public static partial Color ColorSeaGreen();

      [JSImport("SplashKitBackendWASM.color_sea_shell", "main.js")] 
      public static partial Color ColorSeaShell();

      [JSImport("SplashKitBackendWASM.color_sienna", "main.js")] 
      public static partial Color ColorSienna();

      [JSImport("SplashKitBackendWASM.color_silver", "main.js")] 
      public static partial Color ColorSilver();

      [JSImport("SplashKitBackendWASM.color_sky_blue", "main.js")] 
      public static partial Color ColorSkyBlue();

      [JSImport("SplashKitBackendWASM.color_slate_blue", "main.js")] 
      public static partial Color ColorSlateBlue();

      [JSImport("SplashKitBackendWASM.color_slate_gray", "main.js")] 
      public static partial Color ColorSlateGray();

      [JSImport("SplashKitBackendWASM.color_snow", "main.js")] 
      public static partial Color ColorSnow();

      [JSImport("SplashKitBackendWASM.color_spring_green", "main.js")] 
      public static partial Color ColorSpringGreen();

      [JSImport("SplashKitBackendWASM.color_steel_blue", "main.js")] 
      public static partial Color ColorSteelBlue();

      [JSImport("SplashKitBackendWASM.color_swinburne_red", "main.js")] 
      public static partial Color ColorSwinburneRed();

      [JSImport("SplashKitBackendWASM.color_tan", "main.js")] 
      public static partial Color ColorTan();

      [JSImport("SplashKitBackendWASM.color_teal", "main.js")] 
      public static partial Color ColorTeal();

      [JSImport("SplashKitBackendWASM.color_thistle", "main.js")] 
      public static partial Color ColorThistle();

      [JSImport("SplashKitBackendWASM.color_to_string", "main.js")] 
      public static partial string ColorToString(Color c);

      [JSImport("SplashKitBackendWASM.color_tomato", "main.js")] 
      public static partial Color ColorTomato();

      [JSImport("SplashKitBackendWASM.color_transparent", "main.js")] 
      public static partial Color ColorTransparent();

      [JSImport("SplashKitBackendWASM.color_turquoise", "main.js")] 
      public static partial Color ColorTurquoise();

      [JSImport("SplashKitBackendWASM.color_violet", "main.js")] 
      public static partial Color ColorViolet();

      [JSImport("SplashKitBackendWASM.color_wheat", "main.js")] 
      public static partial Color ColorWheat();

      [JSImport("SplashKitBackendWASM.color_white", "main.js")] 
      public static partial Color ColorWhite();

      [JSImport("SplashKitBackendWASM.color_white_smoke", "main.js")] 
      public static partial Color ColorWhiteSmoke();

      [JSImport("SplashKitBackendWASM.color_yellow", "main.js")] 
      public static partial Color ColorYellow();

      [JSImport("SplashKitBackendWASM.color_yellow_green", "main.js")] 
      public static partial Color ColorYellowGreen();

      [JSImport("SplashKitBackendWASM.green_of", "main.js")] 
      public static partial int GreenOf(Color c);

      [JSImport("SplashKitBackendWASM.hsb_color", "main.js")] 
      public static partial Color HSBColor(double hue, double saturation, double brightness);

      [JSImport("SplashKitBackendWASM.hue_of", "main.js")] 
      public static partial double HueOf(Color c);

      [JSImport("SplashKitBackendWASM.random_color", "main.js")] 
      public static partial Color RandomColor();

      [JSImport("SplashKitBackendWASM.random_rgb_color", "main.js")] 
      public static partial Color RandomRGBColor(int alpha);

      [JSImport("SplashKitBackendWASM.red_of", "main.js")] 
      public static partial int RedOf(Color c);

      [JSImport("SplashKitBackendWASM.rgb_color", "main.js")] 
      public static partial Color RGBColor(double red, double green, double blue);

      [JSImport("SplashKitBackendWASM.rgb_color", "main.js")] 
      public static partial Color RGBColor(int red, int green, int blue);

      [JSImport("SplashKitBackendWASM.rgba_color", "main.js")] 
      public static partial Color RGBAColor(double red, double green, double blue, double alpha);

      [JSImport("SplashKitBackendWASM.rgba_color", "main.js")] 
      public static partial Color RGBAColor(int red, int green, int blue, int alpha);

      [JSImport("SplashKitBackendWASM.saturation_of", "main.js")] 
      public static partial double SaturationOf(Color c);

      [JSImport("SplashKitBackendWASM.string_to_color", "main.js")] 
      public static partial Color StringToColor(string str);

      [JSImport("SplashKitBackendWASM.center_point", "main.js")] 
      public static partial Point2D CenterPoint(Circle c);

      [JSImport("SplashKitBackendWASM.circle_at", "main.js")] 
      public static partial Circle CircleAt(Point2D pt, double radius);

      [JSImport("SplashKitBackendWASM.circle_at", "main.js")] 
      public static partial Circle CircleAt(double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.circle_quad_intersect", "main.js")] 
      public static partial bool CircleQuadIntersect(Circle c, Quad q);

      [JSImport("SplashKitBackendWASM.circle_radius", "main.js")] 
      public static partial float CircleRadius(Circle c);

      [JSImport("SplashKitBackendWASM.circle_ray_intersection", "main.js")] 
      public static partial bool CircleRayIntersection(Point2D origin, Vector2D heading, Circle circ);

      [JSImport("SplashKitBackendWASM.circle_ray_intersection", "main.js")] 
      public static partial bool CircleRayIntersection(Point2D origin, Vector2D heading, Circle circ, ref Point2D hitPoint, ref double hitDistance);

      [JSImport("SplashKitBackendWASM.circle_triangle_intersect", "main.js")] 
      public static partial bool CircleTriangleIntersect(Circle c, Triangle tri);

      [JSImport("SplashKitBackendWASM.circle_triangle_intersect", "main.js")] 
      public static partial bool CircleTriangleIntersect(Circle c, Triangle tri, ref Point2D p);

      [JSImport("SplashKitBackendWASM.circle_x", "main.js")] 
      public static partial float CircleX(Circle c);

      [JSImport("SplashKitBackendWASM.circle_y", "main.js")] 
      public static partial float CircleY(Circle c);

      [JSImport("SplashKitBackendWASM.circles_intersect", "main.js")] 
      public static partial bool CirclesIntersect(Circle c1, Circle c2);

      [JSImport("SplashKitBackendWASM.circles_intersect", "main.js")] 
      public static partial bool CirclesIntersect(double c1X, double c1Y, double c1Radius, double c2X, double c2Y, double c2Radius);

      [JSImport("SplashKitBackendWASM.closest_point_on_circle", "main.js")] 
      public static partial Point2D ClosestPointOnCircle(Point2D fromPt, Circle c);

      [JSImport("SplashKitBackendWASM.closest_point_on_line_from_circle", "main.js")] 
      public static partial Point2D ClosestPointOnLineFromCircle(Circle c, Line l);

      [JSImport("SplashKitBackendWASM.closest_point_on_rect_from_circle", "main.js")] 
      public static partial Point2D ClosestPointOnRectFromCircle(Circle c, Rectangle rect);

      [JSImport("SplashKitBackendWASM.closest_point_on_triangle_from_circle", "main.js")] 
      public static partial Point2D ClosestPointOnTriangleFromCircle(Circle c, Triangle tri);

      [JSImport("SplashKitBackendWASM.distant_point_on_circle", "main.js")] 
      public static partial Point2D DistantPointOnCircle(Point2D pt, Circle c);

      [JSImport("SplashKitBackendWASM.distant_point_on_circle_heading", "main.js")] 
      public static partial bool DistantPointOnCircleHeading(Point2D pt, Circle c, Vector2D heading, ref Point2D oppositePt);

      [JSImport("SplashKitBackendWASM.ray_circle_intersect_distance", "main.js")] 
      public static partial float RayCircleIntersectDistance(Point2D rayOrigin, Vector2D rayHeading, Circle c);

      [JSImport("SplashKitBackendWASM.tangent_points", "main.js")] 
      public static partial bool TangentPoints(Point2D fromPt, Circle c, ref Point2D p1, ref Point2D p2);

      [JSImport("SplashKitBackendWASM.widest_points", "main.js")] 
      public static partial void WidestPoints(Circle c, Vector2D along, ref Point2D pt1, ref Point2D pt2);

      [JSImport("SplashKitBackendWASM.cosine", "main.js")] 
      public static partial float Cosine(float degrees);

      [JSImport("SplashKitBackendWASM.sine", "main.js")] 
      public static partial float Sine(float degrees);

      [JSImport("SplashKitBackendWASM.tangent", "main.js")] 
      public static partial float Tangent(float degrees);

      [JSImport("SplashKitBackendWASM.closest_point_on_line", "main.js")] 
      public static partial Point2D ClosestPointOnLine(Point2D fromPt, Line l);

      [JSImport("SplashKitBackendWASM.closest_point_on_lines", "main.js")] 
      public static partial Point2D ClosestPointOnLines(Point2D fromPt, List<Line> lines, ref int lineIdx);

      [JSImport("SplashKitBackendWASM.line_from", "main.js")] 
      public static partial Line LineFrom(Point2D start, Point2D endPt);

      [JSImport("SplashKitBackendWASM.line_from", "main.js")] 
      public static partial Line LineFrom(Point2D start, Vector2D offset);

      [JSImport("SplashKitBackendWASM.line_from", "main.js")] 
      public static partial Line LineFrom(Vector2D v);

      [JSImport("SplashKitBackendWASM.line_from", "main.js")] 
      public static partial Line LineFrom(double x1, double y1, double x2, double y2);

      [JSImport("SplashKitBackendWASM.line_intersection_point", "main.js")] 
      public static partial bool LineIntersectionPoint(Line line1, Line line2, ref Point2D pt);

      [JSImport("SplashKitBackendWASM.line_intersects_circle", "main.js")] 
      public static partial bool LineIntersectsCircle(Line l, Circle c);

      [JSImport("SplashKitBackendWASM.line_intersects_lines", "main.js")] 
      public static partial bool LineIntersectsLines(Line l, List<Line> lines);

      [JSImport("SplashKitBackendWASM.line_intersects_rect", "main.js")] 
      public static partial bool LineIntersectsRect(Line l, Rectangle rect);

      [JSImport("SplashKitBackendWASM.line_length", "main.js")] 
      public static partial float LineLength(Line l);

      [JSImport("SplashKitBackendWASM.line_length_squared", "main.js")] 
      public static partial float LineLengthSquared(Line l);

      [JSImport("SplashKitBackendWASM.line_mid_point", "main.js")] 
      public static partial Point2D LineMidPoint(Line l);

      [JSImport("SplashKitBackendWASM.line_normal", "main.js")] 
      public static partial Vector2D LineNormal(Line l);

      [JSImport("SplashKitBackendWASM.line_to_string", "main.js")] 
      public static partial string LineToString(Line ln);

      [JSImport("SplashKitBackendWASM.lines_from", "main.js")] 
      public static partial List<Line> LinesFrom(Rectangle rect);

      [JSImport("SplashKitBackendWASM.lines_from", "main.js")] 
      public static partial List<Line> LinesFrom(Triangle t);

      [JSImport("SplashKitBackendWASM.lines_intersect", "main.js")] 
      public static partial bool LinesIntersect(Line l1, Line l2);

      [JSImport("SplashKitBackendWASM.point_at", "main.js")] 
      public static partial Point2D PointAt(double x, double y);

      [JSImport("SplashKitBackendWASM.point_at_origin", "main.js")] 
      public static partial Point2D PointAtOrigin();

      [JSImport("SplashKitBackendWASM.point_in_circle", "main.js")] 
      public static partial bool PointInCircle(Point2D pt, Circle c);

      [JSImport("SplashKitBackendWASM.point_in_circle", "main.js")] 
      public static partial bool PointInCircle(double ptx, double pty, double cx, double cy, double radius);

      [JSImport("SplashKitBackendWASM.point_in_quad", "main.js")] 
      public static partial bool PointInQuad(Point2D pt, Quad q);

      [JSImport("SplashKitBackendWASM.point_in_rectangle", "main.js")] 
      public static partial bool PointInRectangle(Point2D pt, Rectangle rect);

      [JSImport("SplashKitBackendWASM.point_in_rectangle", "main.js")] 
      public static partial bool PointInRectangle(double ptx, double pty, double rectX, double rectY, double rectWidth, double rectHeight);

      [JSImport("SplashKitBackendWASM.point_in_triangle", "main.js")] 
      public static partial bool PointInTriangle(Point2D pt, Triangle tri);

      [JSImport("SplashKitBackendWASM.point_line_distance", "main.js")] 
      public static partial float PointLineDistance(Point2D pt, Line l);

      [JSImport("SplashKitBackendWASM.point_offset_by", "main.js")] 
      public static partial Point2D PointOffsetBy(Point2D startPoint, Vector2D offset);

      [JSImport("SplashKitBackendWASM.point_offset_from_origin", "main.js")] 
      public static partial Point2D PointOffsetFromOrigin(Vector2D offset);

      [JSImport("SplashKitBackendWASM.point_on_line", "main.js")] 
      public static partial bool PointOnLine(Point2D pt, Line l);

      [JSImport("SplashKitBackendWASM.point_on_line", "main.js")] 
      public static partial bool PointOnLine(Point2D pt, Line l, float proximity);

      [JSImport("SplashKitBackendWASM.point_point_angle", "main.js")] 
      public static partial float PointPointAngle(Point2D pt1, Point2D pt2);

      [JSImport("SplashKitBackendWASM.point_point_distance", "main.js")] 
      public static partial double PointPointDistance(Point2D pt1, Point2D pt2);

      [JSImport("SplashKitBackendWASM.point_to_string", "main.js")] 
      public static partial string PointToString(Point2D pt);

      [JSImport("SplashKitBackendWASM.random_bitmap_point", "main.js")] 
      public static partial Point2D RandomBitmapPoint(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.random_screen_point", "main.js")] 
      public static partial Point2D RandomScreenPoint();

      [JSImport("SplashKitBackendWASM.random_window_point", "main.js")] 
      public static partial Point2D RandomWindowPoint(Window wind);

      [JSImport("SplashKitBackendWASM.same_point", "main.js")] 
      public static partial bool SamePoint(Point2D pt1, Point2D pt2);

      [JSImport("SplashKitBackendWASM.quad_from", "main.js")] 
      public static partial Quad QuadFrom(Point2D lineOrigin, Point2D lineEnd, double width);

      [JSImport("SplashKitBackendWASM.quad_from", "main.js")] 
      public static partial Quad QuadFrom(Point2D p1, Point2D p2, Point2D p3, Point2D p4);

      [JSImport("SplashKitBackendWASM.quad_from", "main.js")] 
      public static partial Quad QuadFrom(Rectangle rect);

      [JSImport("SplashKitBackendWASM.quad_from", "main.js")] 
      public static partial Quad QuadFrom(Rectangle rect, Matrix2D transform);

      [JSImport("SplashKitBackendWASM.quad_from", "main.js")] 
      public static partial Quad QuadFrom(double xTopLeft, double yTopLeft, double xTopRight, double yTopRight, double xBottomLeft, double yBottomLeft, double xBottomRight, double yBottomRight);

      [JSImport("SplashKitBackendWASM.quad_ray_intersection", "main.js")] 
      public static partial bool QuadRayIntersection(Point2D origin, Vector2D heading, Quad q);

      [JSImport("SplashKitBackendWASM.quad_ray_intersection", "main.js")] 
      public static partial bool QuadRayIntersection(Point2D origin, Vector2D heading, Quad q, ref Point2D hitPoint, ref double hitDistance);

      [JSImport("SplashKitBackendWASM.quads_intersect", "main.js")] 
      public static partial bool QuadsIntersect(Quad q1, Quad q2);

      [JSImport("SplashKitBackendWASM.set_quad_point", "main.js")] 
      public static partial void SetQuadPoint(ref Quad q, int idx, Point2D value);

      [JSImport("SplashKitBackendWASM.triangles_from", "main.js")] 
      public static partial List<Triangle> TrianglesFrom(Quad q);

      [JSImport("SplashKitBackendWASM.inset_rectangle", "main.js")] 
      public static partial Rectangle InsetRectangle(Rectangle rect, float insetAmount);

      [JSImport("SplashKitBackendWASM.intersection", "main.js")] 
      public static partial Rectangle Intersection(Rectangle rect1, Rectangle rect2);

      [JSImport("SplashKitBackendWASM.rectangle_around", "main.js")] 
      public static partial Rectangle RectangleAround(Circle c);

      [JSImport("SplashKitBackendWASM.rectangle_around", "main.js")] 
      public static partial Rectangle RectangleAround(Line l);

      [JSImport("SplashKitBackendWASM.rectangle_around", "main.js")] 
      public static partial Rectangle RectangleAround(Quad q);

      [JSImport("SplashKitBackendWASM.rectangle_around", "main.js")] 
      public static partial Rectangle RectangleAround(Triangle t);

      [JSImport("SplashKitBackendWASM.rectangle_bottom", "main.js")] 
      public static partial double RectangleBottom(Rectangle rect);

      [JSImport("SplashKitBackendWASM.rectangle_center", "main.js")] 
      public static partial Point2D RectangleCenter(Rectangle rect);

      [JSImport("SplashKitBackendWASM.rectangle_circle_intersect", "main.js")] 
      public static partial bool RectangleCircleIntersect(Rectangle rect, Circle c);

      [JSImport("SplashKitBackendWASM.rectangle_from", "main.js")] 
      public static partial Rectangle RectangleFrom(Point2D pt, double width, double height);

      [JSImport("SplashKitBackendWASM.rectangle_from", "main.js")] 
      public static partial Rectangle RectangleFrom(Point2D pt1, Point2D pt2);

      [JSImport("SplashKitBackendWASM.rectangle_from", "main.js")] 
      public static partial Rectangle RectangleFrom(double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.rectangle_left", "main.js")] 
      public static partial double RectangleLeft(Rectangle rect);

      [JSImport("SplashKitBackendWASM.rectangle_offset_by", "main.js")] 
      public static partial Rectangle RectangleOffsetBy(Rectangle rect, Vector2D offset);

      [JSImport("SplashKitBackendWASM.rectangle_ray_intersection", "main.js")] 
      public static partial bool RectangleRayIntersection(Point2D origin, Vector2D heading, Rectangle rect);

      [JSImport("SplashKitBackendWASM.rectangle_ray_intersection", "main.js")] 
      public static partial bool RectangleRayIntersection(Point2D origin, Vector2D heading, Rectangle rect, ref Point2D hitPoint, ref double hitDistance);

      [JSImport("SplashKitBackendWASM.rectangle_right", "main.js")] 
      public static partial double RectangleRight(Rectangle rect);

      [JSImport("SplashKitBackendWASM.rectangle_to_string", "main.js")] 
      public static partial string RectangleToString(Rectangle rect);

      [JSImport("SplashKitBackendWASM.rectangle_top", "main.js")] 
      public static partial double RectangleTop(Rectangle rect);

      [JSImport("SplashKitBackendWASM.rectangles_intersect", "main.js")] 
      public static partial bool RectanglesIntersect(Rectangle rect1, Rectangle rect2);

      [JSImport("SplashKitBackendWASM.triangle_barycenter", "main.js")] 
      public static partial Point2D TriangleBarycenter(Triangle tri);

      [JSImport("SplashKitBackendWASM.triangle_from", "main.js")] 
      public static partial Triangle TriangleFrom(Point2D p1, Point2D p2, Point2D p3);

      [JSImport("SplashKitBackendWASM.triangle_from", "main.js")] 
      public static partial Triangle TriangleFrom(double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.triangle_quad_intersect", "main.js")] 
      public static partial bool TriangleQuadIntersect(Triangle tri, Quad q);

      [JSImport("SplashKitBackendWASM.triangle_ray_intersection", "main.js")] 
      public static partial bool TriangleRayIntersection(Point2D origin, Vector2D heading, Triangle tri);

      [JSImport("SplashKitBackendWASM.triangle_ray_intersection", "main.js")] 
      public static partial bool TriangleRayIntersection(Point2D origin, Vector2D heading, Triangle tri, ref Point2D hitPoint, ref double hitDistance);

      [JSImport("SplashKitBackendWASM.triangle_rectangle_intersect", "main.js")] 
      public static partial bool TriangleRectangleIntersect(Triangle tri, Rectangle rect);

      [JSImport("SplashKitBackendWASM.triangle_to_string", "main.js")] 
      public static partial string TriangleToString(Triangle tri);

      [JSImport("SplashKitBackendWASM.triangles_intersect", "main.js")] 
      public static partial bool TrianglesIntersect(Triangle t1, Triangle t2);

      [JSImport("SplashKitBackendWASM.draw_circle", "main.js")] 
      public static partial void DrawCircle(Color clr, Circle c);

      [JSImport("SplashKitBackendWASM.draw_circle", "main.js")] 
      public static partial void DrawCircle(Color clr, Circle c, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_circle", "main.js")] 
      public static partial void DrawCircle(Color clr, Point2D pt, double radius);

      [JSImport("SplashKitBackendWASM.draw_circle", "main.js")] 
      public static partial void DrawCircle(Color clr, Point2D pt, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_circle", "main.js")] 
      public static partial void DrawCircle(Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.draw_circle", "main.js")] 
      public static partial void DrawCircle(Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_circle_on_bitmap", "main.js")] 
      public static partial void DrawCircleOnBitmap(Bitmap destination, Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.draw_circle_on_bitmap", "main.js")] 
      public static partial void DrawCircleOnBitmap(Bitmap destination, Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_circle_on_window", "main.js")] 
      public static partial void DrawCircleOnWindow(Window destination, Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.draw_circle_on_window", "main.js")] 
      public static partial void DrawCircleOnWindow(Window destination, Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_circle", "main.js")] 
      public static partial void FillCircle(Color clr, Circle c);

      [JSImport("SplashKitBackendWASM.fill_circle", "main.js")] 
      public static partial void FillCircle(Color clr, Circle c, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_circle", "main.js")] 
      public static partial void FillCircle(Color clr, Point2D pt, double radius);

      [JSImport("SplashKitBackendWASM.fill_circle", "main.js")] 
      public static partial void FillCircle(Color clr, Point2D pt, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_circle", "main.js")] 
      public static partial void FillCircle(Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.fill_circle", "main.js")] 
      public static partial void FillCircle(Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_circle_on_bitmap", "main.js")] 
      public static partial void FillCircleOnBitmap(Bitmap destination, Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.fill_circle_on_bitmap", "main.js")] 
      public static partial void FillCircleOnBitmap(Bitmap destination, Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_circle_on_window", "main.js")] 
      public static partial void FillCircleOnWindow(Window destination, Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.fill_circle_on_window", "main.js")] 
      public static partial void FillCircleOnWindow(Window destination, Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.current_clip", "main.js")] 
      public static partial Rectangle CurrentClip();

      [JSImport("SplashKitBackendWASM.current_clip", "main.js")] 
      public static partial Rectangle CurrentClip(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.current_clip", "main.js")] 
      public static partial Rectangle CurrentClip(Window wnd);

      [JSImport("SplashKitBackendWASM.pop_clip", "main.js")] 
      public static partial void PopClip(Window wnd);

      [JSImport("SplashKitBackendWASM.pop_clip", "main.js")] 
      public static partial void PopClip();

      [JSImport("SplashKitBackendWASM.pop_clip", "main.js")] 
      public static partial void PopClip(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.push_clip", "main.js")] 
      public static partial void PushClip(Window wnd, Rectangle r);

      [JSImport("SplashKitBackendWASM.push_clip", "main.js")] 
      public static partial void PushClip(Bitmap bmp, Rectangle r);

      [JSImport("SplashKitBackendWASM.push_clip", "main.js")] 
      public static partial void PushClip(Rectangle r);

      [JSImport("SplashKitBackendWASM.reset_clip", "main.js")] 
      public static partial void ResetClip(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.reset_clip", "main.js")] 
      public static partial void ResetClip();

      [JSImport("SplashKitBackendWASM.reset_clip", "main.js")] 
      public static partial void ResetClip(Window wnd);

      [JSImport("SplashKitBackendWASM.set_clip", "main.js")] 
      public static partial void SetClip(Rectangle r);

      [JSImport("SplashKitBackendWASM.set_clip", "main.js")] 
      public static partial void SetClip(Bitmap bmp, Rectangle r);

      [JSImport("SplashKitBackendWASM.set_clip", "main.js")] 
      public static partial void SetClip(Window wnd, Rectangle r);

      [JSImport("SplashKitBackendWASM.option_defaults", "main.js")] 
      public static partial DrawingOptions OptionDefaults();

      [JSImport("SplashKitBackendWASM.option_draw_to", "main.js")] 
      public static partial DrawingOptions OptionDrawTo(Bitmap dest);

      [JSImport("SplashKitBackendWASM.option_draw_to", "main.js")] 
      public static partial DrawingOptions OptionDrawTo(Bitmap dest, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_draw_to", "main.js")] 
      public static partial DrawingOptions OptionDrawTo(Window dest);

      [JSImport("SplashKitBackendWASM.option_draw_to", "main.js")] 
      public static partial DrawingOptions OptionDrawTo(Window dest, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_flip_x", "main.js")] 
      public static partial DrawingOptions OptionFlipX();

      [JSImport("SplashKitBackendWASM.option_flip_x", "main.js")] 
      public static partial DrawingOptions OptionFlipX(DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_flip_xy", "main.js")] 
      public static partial DrawingOptions OptionFlipXy();

      [JSImport("SplashKitBackendWASM.option_flip_xy", "main.js")] 
      public static partial DrawingOptions OptionFlipXy(DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_flip_y", "main.js")] 
      public static partial DrawingOptions OptionFlipY();

      [JSImport("SplashKitBackendWASM.option_flip_y", "main.js")] 
      public static partial DrawingOptions OptionFlipY(DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_line_width", "main.js")] 
      public static partial DrawingOptions OptionLineWidth(int width);

      [JSImport("SplashKitBackendWASM.option_line_width", "main.js")] 
      public static partial DrawingOptions OptionLineWidth(int width, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_part_bmp", "main.js")] 
      public static partial DrawingOptions OptionPartBmp(double x, double y, double w, double h);

      [JSImport("SplashKitBackendWASM.option_part_bmp", "main.js")] 
      public static partial DrawingOptions OptionPartBmp(double x, double y, double w, double h, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_part_bmp", "main.js")] 
      public static partial DrawingOptions OptionPartBmp(Rectangle part);

      [JSImport("SplashKitBackendWASM.option_part_bmp", "main.js")] 
      public static partial DrawingOptions OptionPartBmp(Rectangle part, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_rotate_bmp", "main.js")] 
      public static partial DrawingOptions OptionRotateBmp(double angle);

      [JSImport("SplashKitBackendWASM.option_rotate_bmp", "main.js")] 
      public static partial DrawingOptions OptionRotateBmp(double angle, double anchorX, double anchorY);

      [JSImport("SplashKitBackendWASM.option_rotate_bmp", "main.js")] 
      public static partial DrawingOptions OptionRotateBmp(double angle, double anchorX, double anchorY, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_rotate_bmp", "main.js")] 
      public static partial DrawingOptions OptionRotateBmp(double angle, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_scale_bmp", "main.js")] 
      public static partial DrawingOptions OptionScaleBmp(double scaleX, double scaleY);

      [JSImport("SplashKitBackendWASM.option_scale_bmp", "main.js")] 
      public static partial DrawingOptions OptionScaleBmp(double scaleX, double scaleY, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_to_screen", "main.js")] 
      public static partial DrawingOptions OptionToScreen();

      [JSImport("SplashKitBackendWASM.option_to_screen", "main.js")] 
      public static partial DrawingOptions OptionToScreen(DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_to_world", "main.js")] 
      public static partial DrawingOptions OptionToWorld();

      [JSImport("SplashKitBackendWASM.option_to_world", "main.js")] 
      public static partial DrawingOptions OptionToWorld(DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_with_animation", "main.js")] 
      public static partial DrawingOptions OptionWithAnimation(Animation anim);

      [JSImport("SplashKitBackendWASM.option_with_animation", "main.js")] 
      public static partial DrawingOptions OptionWithAnimation(Animation anim, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.option_with_bitmap_cell", "main.js")] 
      public static partial DrawingOptions OptionWithBitmapCell(int cell);

      [JSImport("SplashKitBackendWASM.option_with_bitmap_cell", "main.js")] 
      public static partial DrawingOptions OptionWithBitmapCell(int cell, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse", "main.js")] 
      public static partial void DrawEllipse(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_ellipse", "main.js")] 
      public static partial void DrawEllipse(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse", "main.js")] 
      public static partial void DrawEllipse(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_ellipse", "main.js")] 
      public static partial void DrawEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_bitmap", "main.js")] 
      public static partial void DrawEllipseOnBitmap(Bitmap destination, Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_bitmap", "main.js")] 
      public static partial void DrawEllipseOnBitmap(Bitmap destination, Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_bitmap", "main.js")] 
      public static partial void DrawEllipseOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_bitmap", "main.js")] 
      public static partial void DrawEllipseOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_window", "main.js")] 
      public static partial void DrawEllipseOnWindow(Window destination, Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_window", "main.js")] 
      public static partial void DrawEllipseOnWindow(Window destination, Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_window", "main.js")] 
      public static partial void DrawEllipseOnWindow(Window destination, Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_window", "main.js")] 
      public static partial void DrawEllipseOnWindow(Window destination, Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse", "main.js")] 
      public static partial void FillEllipse(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_ellipse", "main.js")] 
      public static partial void FillEllipse(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse", "main.js")] 
      public static partial void FillEllipse(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_ellipse", "main.js")] 
      public static partial void FillEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_bitmap", "main.js")] 
      public static partial void FillEllipseOnBitmap(Bitmap destination, Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_bitmap", "main.js")] 
      public static partial void FillEllipseOnBitmap(Bitmap destination, Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_bitmap", "main.js")] 
      public static partial void FillEllipseOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_bitmap", "main.js")] 
      public static partial void FillEllipseOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_window", "main.js")] 
      public static partial void FillEllipseOnWindow(Window destination, Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_window", "main.js")] 
      public static partial void FillEllipseOnWindow(Window destination, Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_window", "main.js")] 
      public static partial void FillEllipseOnWindow(Window destination, Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_window", "main.js")] 
      public static partial void FillEllipseOnWindow(Window destination, Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.clear_screen", "main.js")] 
      public static partial void ClearScreen();

      [JSImport("SplashKitBackendWASM.clear_screen", "main.js")] 
      public static partial void ClearScreen(Color clr);

      [JSImport("SplashKitBackendWASM.display_details", "main.js")] 
      public static partial Display DisplayDetails(uint index);

      [JSImport("SplashKitBackendWASM.display_height", "main.js")] 
      public static partial int DisplayHeight(Display disp);

      [JSImport("SplashKitBackendWASM.display_name", "main.js")] 
      public static partial string DisplayName(Display disp);

      [JSImport("SplashKitBackendWASM.display_width", "main.js")] 
      public static partial int DisplayWidth(Display disp);

      [JSImport("SplashKitBackendWASM.display_x", "main.js")] 
      public static partial int DisplayX(Display disp);

      [JSImport("SplashKitBackendWASM.display_y", "main.js")] 
      public static partial int DisplayY(Display disp);

      [JSImport("SplashKitBackendWASM.number_of_displays", "main.js")] 
      public static partial int NumberOfDisplays();

      [JSImport("SplashKitBackendWASM.refresh_screen", "main.js")] 
      public static partial void RefreshScreen();

      [JSImport("SplashKitBackendWASM.refresh_screen", "main.js")] 
      public static partial void RefreshScreen(uint targetFps);

      [JSImport("SplashKitBackendWASM.save_bitmap", "main.js")] 
      public static partial void SaveBitmap(Bitmap bmp, string basename);

      [JSImport("SplashKitBackendWASM.screen_height", "main.js")] 
      public static partial int ScreenHeight();

      [JSImport("SplashKitBackendWASM.screen_width", "main.js")] 
      public static partial int ScreenWidth();

      [JSImport("SplashKitBackendWASM.take_screenshot", "main.js")] 
      public static partial void TakeScreenshot(string basename);

      [JSImport("SplashKitBackendWASM.take_screenshot", "main.js")] 
      public static partial void TakeScreenshot(Window wind, string basename);

      [JSImport("SplashKitBackendWASM.bitmap_bounding_circle", "main.js")] 
      public static partial Circle BitmapBoundingCircle(Bitmap bmp, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_bounding_rectangle", "main.js")] 
      public static partial Rectangle BitmapBoundingRectangle(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_bounding_rectangle", "main.js")] 
      public static partial Rectangle BitmapBoundingRectangle(Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.bitmap_cell_center", "main.js")] 
      public static partial Point2D BitmapCellCenter(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_cell_circle", "main.js")] 
      public static partial Circle BitmapCellCircle(Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.bitmap_cell_circle", "main.js")] 
      public static partial Circle BitmapCellCircle(Bitmap bmp, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_cell_circle", "main.js")] 
      public static partial Circle BitmapCellCircle(Bitmap bmp, Point2D pt, double scale);

      [JSImport("SplashKitBackendWASM.bitmap_cell_columns", "main.js")] 
      public static partial int BitmapCellColumns(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_cell_count", "main.js")] 
      public static partial int BitmapCellCount(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_cell_height", "main.js")] 
      public static partial int BitmapCellHeight(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_cell_offset", "main.js")] 
      public static partial Vector2D BitmapCellOffset(Bitmap src, int cell);

      [JSImport("SplashKitBackendWASM.bitmap_cell_rectangle", "main.js")] 
      public static partial Rectangle BitmapCellRectangle(Bitmap src);

      [JSImport("SplashKitBackendWASM.bitmap_cell_rectangle", "main.js")] 
      public static partial Rectangle BitmapCellRectangle(Bitmap src, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_cell_rows", "main.js")] 
      public static partial int BitmapCellRows(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_cell_width", "main.js")] 
      public static partial int BitmapCellWidth(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_center", "main.js")] 
      public static partial Point2D BitmapCenter(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_filename", "main.js")] 
      public static partial string BitmapFilename(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_height", "main.js")] 
      public static partial int BitmapHeight(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_height", "main.js")] 
      public static partial int BitmapHeight(string name);

      [JSImport("SplashKitBackendWASM.bitmap_name", "main.js")] 
      public static partial string BitmapName(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_named", "main.js")] 
      public static partial Bitmap BitmapNamed(string name);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_of_cell", "main.js")] 
      public static partial Rectangle BitmapRectangleOfCell(Bitmap src, int cell);

      [JSImport("SplashKitBackendWASM.bitmap_set_cell_details", "main.js")] 
      public static partial void BitmapSetCellDetails(Bitmap bmp, int width, int height, int columns, int rows, int count);

      [JSImport("SplashKitBackendWASM.bitmap_valid", "main.js")] 
      public static partial bool BitmapValid(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_width", "main.js")] 
      public static partial int BitmapWidth(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_width", "main.js")] 
      public static partial int BitmapWidth(string name);

      [JSImport("SplashKitBackendWASM.clear_bitmap", "main.js")] 
      public static partial void ClearBitmap(Bitmap bmp, Color clr);

      [JSImport("SplashKitBackendWASM.clear_bitmap", "main.js")] 
      public static partial void ClearBitmap(string name, Color clr);

      [JSImport("SplashKitBackendWASM.create_bitmap", "main.js")] 
      public static partial Bitmap CreateBitmap(string name, int width, int height);

      [JSImport("SplashKitBackendWASM.draw_bitmap", "main.js")] 
      public static partial void DrawBitmap(Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_bitmap", "main.js")] 
      public static partial void DrawBitmap(Bitmap bmp, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_bitmap", "main.js")] 
      public static partial void DrawBitmap(string name, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_bitmap", "main.js")] 
      public static partial void DrawBitmap(string name, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_bitmap_on_bitmap", "main.js")] 
      public static partial void DrawBitmapOnBitmap(Bitmap destination, Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_bitmap_on_bitmap", "main.js")] 
      public static partial void DrawBitmapOnBitmap(Bitmap destination, Bitmap bmp, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_bitmap_on_window", "main.js")] 
      public static partial void DrawBitmapOnWindow(Window destination, Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_bitmap_on_window", "main.js")] 
      public static partial void DrawBitmapOnWindow(Window destination, Bitmap bmp, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.free_all_bitmaps", "main.js")] 
      public static partial void FreeAllBitmaps();

      [JSImport("SplashKitBackendWASM.free_bitmap", "main.js")] 
      public static partial void FreeBitmap(Bitmap toDelete);

      [JSImport("SplashKitBackendWASM.has_bitmap", "main.js")] 
      public static partial bool HasBitmap(string name);

      [JSImport("SplashKitBackendWASM.load_bitmap", "main.js")] 
      public static partial Bitmap LoadBitmap(string name, string filename);

      [JSImport("SplashKitBackendWASM.pixel_drawn_at_point", "main.js")] 
      public static partial bool PixelDrawnAtPoint(Bitmap bmp, Point2D pt);

      [JSImport("SplashKitBackendWASM.pixel_drawn_at_point", "main.js")] 
      public static partial bool PixelDrawnAtPoint(Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.pixel_drawn_at_point", "main.js")] 
      public static partial bool PixelDrawnAtPoint(Bitmap bmp, int cell, Point2D pt);

      [JSImport("SplashKitBackendWASM.pixel_drawn_at_point", "main.js")] 
      public static partial bool PixelDrawnAtPoint(Bitmap bmp, int cell, double x, double y);

      [JSImport("SplashKitBackendWASM.setup_collision_mask", "main.js")] 
      public static partial void SetupCollisionMask(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.draw_line", "main.js")] 
      public static partial void DrawLine(Color clr, Line l);

      [JSImport("SplashKitBackendWASM.draw_line", "main.js")] 
      public static partial void DrawLine(Color clr, Line l, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line", "main.js")] 
      public static partial void DrawLine(Color clr, Point2D fromPt, Point2D toPt);

      [JSImport("SplashKitBackendWASM.draw_line", "main.js")] 
      public static partial void DrawLine(Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line", "main.js")] 
      public static partial void DrawLine(Color clr, double x1, double y1, double x2, double y2);

      [JSImport("SplashKitBackendWASM.draw_line", "main.js")] 
      public static partial void DrawLine(Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public static partial void DrawLineOnBitmap(Bitmap destination, Color clr, Line l);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public static partial void DrawLineOnBitmap(Bitmap destination, Color clr, Line l, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public static partial void DrawLineOnBitmap(Bitmap destination, Color clr, Point2D fromPt, Point2D toPt);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public static partial void DrawLineOnBitmap(Bitmap destination, Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public static partial void DrawLineOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public static partial void DrawLineOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public static partial void DrawLineOnWindow(Window destination, Color clr, Line l);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public static partial void DrawLineOnWindow(Window destination, Color clr, Line l, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public static partial void DrawLineOnWindow(Window destination, Color clr, Point2D fromPt, Point2D toPt);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public static partial void DrawLineOnWindow(Window destination, Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public static partial void DrawLineOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public static partial void DrawLineOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel", "main.js")] 
      public static partial void DrawPixel(Color clr, Point2D pt);

      [JSImport("SplashKitBackendWASM.draw_pixel", "main.js")] 
      public static partial void DrawPixel(Color clr, Point2D pt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel", "main.js")] 
      public static partial void DrawPixel(Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_pixel", "main.js")] 
      public static partial void DrawPixel(Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_bitmap", "main.js")] 
      public static partial void DrawPixelOnBitmap(Bitmap destination, Color clr, Point2D pt);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_bitmap", "main.js")] 
      public static partial void DrawPixelOnBitmap(Bitmap destination, Color clr, Point2D pt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_bitmap", "main.js")] 
      public static partial void DrawPixelOnBitmap(Bitmap destination, Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_bitmap", "main.js")] 
      public static partial void DrawPixelOnBitmap(Bitmap destination, Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_window", "main.js")] 
      public static partial void DrawPixelOnWindow(Window destination, Color clr, Point2D pt);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_window", "main.js")] 
      public static partial void DrawPixelOnWindow(Window destination, Color clr, Point2D pt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_window", "main.js")] 
      public static partial void DrawPixelOnWindow(Window destination, Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_window", "main.js")] 
      public static partial void DrawPixelOnWindow(Window destination, Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.get_pixel", "main.js")] 
      public static partial Color GetPixel(Bitmap bmp, Point2D pt);

      [JSImport("SplashKitBackendWASM.get_pixel", "main.js")] 
      public static partial Color GetPixel(Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.get_pixel", "main.js")] 
      public static partial Color GetPixel(Point2D pt);

      [JSImport("SplashKitBackendWASM.get_pixel", "main.js")] 
      public static partial Color GetPixel(double x, double y);

      [JSImport("SplashKitBackendWASM.get_pixel", "main.js")] 
      public static partial Color GetPixel(Window wnd, Point2D pt);

      [JSImport("SplashKitBackendWASM.get_pixel", "main.js")] 
      public static partial Color GetPixel(Window wnd, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_quad", "main.js")] 
      public static partial void DrawQuad(Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.draw_quad", "main.js")] 
      public static partial void DrawQuad(Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_quad_on_bitmap", "main.js")] 
      public static partial void DrawQuadOnBitmap(Bitmap destination, Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.draw_quad_on_bitmap", "main.js")] 
      public static partial void DrawQuadOnBitmap(Bitmap destination, Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_quad_on_window", "main.js")] 
      public static partial void DrawQuadOnWindow(Window destination, Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.draw_quad_on_window", "main.js")] 
      public static partial void DrawQuadOnWindow(Window destination, Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle", "main.js")] 
      public static partial void DrawRectangle(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_rectangle", "main.js")] 
      public static partial void DrawRectangle(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle", "main.js")] 
      public static partial void DrawRectangle(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_rectangle", "main.js")] 
      public static partial void DrawRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_bitmap", "main.js")] 
      public static partial void DrawRectangleOnBitmap(Bitmap destination, Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_bitmap", "main.js")] 
      public static partial void DrawRectangleOnBitmap(Bitmap destination, Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_bitmap", "main.js")] 
      public static partial void DrawRectangleOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_bitmap", "main.js")] 
      public static partial void DrawRectangleOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_window", "main.js")] 
      public static partial void DrawRectangleOnWindow(Window destination, Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_window", "main.js")] 
      public static partial void DrawRectangleOnWindow(Window destination, Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_window", "main.js")] 
      public static partial void DrawRectangleOnWindow(Window destination, Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_window", "main.js")] 
      public static partial void DrawRectangleOnWindow(Window destination, Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_quad", "main.js")] 
      public static partial void FillQuad(Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.fill_quad", "main.js")] 
      public static partial void FillQuad(Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_quad_on_bitmap", "main.js")] 
      public static partial void FillQuadOnBitmap(Bitmap destination, Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.fill_quad_on_bitmap", "main.js")] 
      public static partial void FillQuadOnBitmap(Bitmap destination, Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_quad_on_window", "main.js")] 
      public static partial void FillQuadOnWindow(Window destination, Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.fill_quad_on_window", "main.js")] 
      public static partial void FillQuadOnWindow(Window destination, Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle", "main.js")] 
      public static partial void FillRectangle(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_rectangle", "main.js")] 
      public static partial void FillRectangle(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle", "main.js")] 
      public static partial void FillRectangle(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_rectangle", "main.js")] 
      public static partial void FillRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_bitmap", "main.js")] 
      public static partial void FillRectangleOnBitmap(Bitmap destination, Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_bitmap", "main.js")] 
      public static partial void FillRectangleOnBitmap(Bitmap destination, Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_bitmap", "main.js")] 
      public static partial void FillRectangleOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_bitmap", "main.js")] 
      public static partial void FillRectangleOnBitmap(Bitmap destination, Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_window", "main.js")] 
      public static partial void FillRectangleOnWindow(Window destination, Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_window", "main.js")] 
      public static partial void FillRectangleOnWindow(Window destination, Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_window", "main.js")] 
      public static partial void FillRectangleOnWindow(Window destination, Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_window", "main.js")] 
      public static partial void FillRectangleOnWindow(Window destination, Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text", "main.js")] 
      public static partial void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text", "main.js")] 
      public static partial void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text", "main.js")] 
      public static partial void DrawText(string text, Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text", "main.js")] 
      public static partial void DrawText(string text, Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text", "main.js")] 
      public static partial void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text", "main.js")] 
      public static partial void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public static partial void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, string fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public static partial void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public static partial void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public static partial void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public static partial void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, Font fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public static partial void DrawTextOnBitmap(Bitmap bmp, string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public static partial void DrawTextOnWindow(Window wnd, string text, Color clr, string fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public static partial void DrawTextOnWindow(Window wnd, string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public static partial void DrawTextOnWindow(Window wnd, string text, Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public static partial void DrawTextOnWindow(Window wnd, string text, Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public static partial void DrawTextOnWindow(Window wnd, string text, Color clr, Font fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public static partial void DrawTextOnWindow(Window wnd, string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.font_has_size", "main.js")] 
      public static partial bool FontHasSize(string name, int fontSize);

      [JSImport("SplashKitBackendWASM.font_has_size", "main.js")] 
      public static partial bool FontHasSize(Font fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.font_load_size", "main.js")] 
      public static partial void FontLoadSize(string name, int fontSize);

      [JSImport("SplashKitBackendWASM.font_load_size", "main.js")] 
      public static partial void FontLoadSize(Font fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.font_named", "main.js")] 
      public static partial Font FontNamed(string name);

      [JSImport("SplashKitBackendWASM.free_all_fonts", "main.js")] 
      public static partial void FreeAllFonts();

      [JSImport("SplashKitBackendWASM.free_font", "main.js")] 
      public static partial void FreeFont(Font fnt);

      [JSImport("SplashKitBackendWASM.get_font_style", "main.js")] 
      public static partial FontStyle GetFontStyle(string name);

      [JSImport("SplashKitBackendWASM.get_font_style", "main.js")] 
      public static partial FontStyle GetFontStyle(Font fnt);

      [JSImport("SplashKitBackendWASM.get_system_font", "main.js")] 
      public static partial Font GetSystemFont();

      [JSImport("SplashKitBackendWASM.has_font", "main.js")] 
      public static partial bool HasFont(Font fnt);

      [JSImport("SplashKitBackendWASM.has_font", "main.js")] 
      public static partial bool HasFont(string name);

      [JSImport("SplashKitBackendWASM.load_font", "main.js")] 
      public static partial Font LoadFont(string name, string filename);

      [JSImport("SplashKitBackendWASM.set_font_style", "main.js")] 
      public static partial void SetFontStyle(string name, FontStyle style);

      [JSImport("SplashKitBackendWASM.set_font_style", "main.js")] 
      public static partial void SetFontStyle(Font fnt, FontStyle style);

      [JSImport("SplashKitBackendWASM.text_height", "main.js")] 
      public static partial int TextHeight(string text, string fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.text_height", "main.js")] 
      public static partial int TextHeight(string text, Font fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.text_width", "main.js")] 
      public static partial int TextWidth(string text, string fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.text_width", "main.js")] 
      public static partial int TextWidth(string text, Font fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.draw_triangle", "main.js")] 
      public static partial void DrawTriangle(Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.draw_triangle", "main.js")] 
      public static partial void DrawTriangle(Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle", "main.js")] 
      public static partial void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.draw_triangle", "main.js")] 
      public static partial void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_bitmap", "main.js")] 
      public static partial void DrawTriangleOnBitmap(Bitmap destination, Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_bitmap", "main.js")] 
      public static partial void DrawTriangleOnBitmap(Bitmap destination, Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_bitmap", "main.js")] 
      public static partial void DrawTriangleOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_bitmap", "main.js")] 
      public static partial void DrawTriangleOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_window", "main.js")] 
      public static partial void DrawTriangleOnWindow(Window destination, Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_window", "main.js")] 
      public static partial void DrawTriangleOnWindow(Window destination, Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_window", "main.js")] 
      public static partial void DrawTriangleOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_window", "main.js")] 
      public static partial void DrawTriangleOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle", "main.js")] 
      public static partial void FillTriangle(Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.fill_triangle", "main.js")] 
      public static partial void FillTriangle(Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle", "main.js")] 
      public static partial void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.fill_triangle", "main.js")] 
      public static partial void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_bitmap", "main.js")] 
      public static partial void FillTriangleOnBitmap(Bitmap destination, Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_bitmap", "main.js")] 
      public static partial void FillTriangleOnBitmap(Bitmap destination, Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_bitmap", "main.js")] 
      public static partial void FillTriangleOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_bitmap", "main.js")] 
      public static partial void FillTriangleOnBitmap(Bitmap destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_window", "main.js")] 
      public static partial void FillTriangleOnWindow(Window destination, Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_window", "main.js")] 
      public static partial void FillTriangleOnWindow(Window destination, Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_window", "main.js")] 
      public static partial void FillTriangleOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_window", "main.js")] 
      public static partial void FillTriangleOnWindow(Window destination, Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.process_events", "main.js")] 
      public static partial void ProcessEvents();

      [JSImport("SplashKitBackendWASM.quit_requested", "main.js")] 
      public static partial bool QuitRequested();

      [JSImport("SplashKitBackendWASM.reset_quit", "main.js")] 
      public static partial void ResetQuit();

      [JSImport("SplashKitBackendWASM.any_key_pressed", "main.js")] 
      public static partial bool AnyKeyPressed();

      [JSImport("SplashKitBackendWASM.deregister_callback_on_key_down", "main.js")] 
      public static partial void DeregisterCallbackOnKeyDown(KeyCallback callback);

      [JSImport("SplashKitBackendWASM.deregister_callback_on_key_typed", "main.js")] 
      public static partial void DeregisterCallbackOnKeyTyped(KeyCallback callback);

      [JSImport("SplashKitBackendWASM.deregister_callback_on_key_up", "main.js")] 
      public static partial void DeregisterCallbackOnKeyUp(KeyCallback callback);

      [JSImport("SplashKitBackendWASM.key_down", "main.js")] 
      public static partial bool KeyDown(KeyCode key);

      [JSImport("SplashKitBackendWASM.key_name", "main.js")] 
      public static partial string KeyName(KeyCode key);

      [JSImport("SplashKitBackendWASM.key_released", "main.js")] 
      public static partial bool KeyReleased(KeyCode key);

      [JSImport("SplashKitBackendWASM.key_typed", "main.js")] 
      public static partial bool KeyTyped(KeyCode key);

      [JSImport("SplashKitBackendWASM.key_up", "main.js")] 
      public static partial bool KeyUp(KeyCode key);

      [JSImport("SplashKitBackendWASM.register_callback_on_key_down", "main.js")] 
      public static partial void RegisterCallbackOnKeyDown(KeyCallback callback);

      [JSImport("SplashKitBackendWASM.register_callback_on_key_typed", "main.js")] 
      public static partial void RegisterCallbackOnKeyTyped(KeyCallback callback);

      [JSImport("SplashKitBackendWASM.register_callback_on_key_up", "main.js")] 
      public static partial void RegisterCallbackOnKeyUp(KeyCallback callback);

      [JSImport("SplashKitBackendWASM.hide_mouse", "main.js")] 
      public static partial void HideMouse();

      [JSImport("SplashKitBackendWASM.mouse_clicked", "main.js")] 
      public static partial bool MouseClicked(MouseButton button);

      [JSImport("SplashKitBackendWASM.mouse_down", "main.js")] 
      public static partial bool MouseDown(MouseButton button);

      [JSImport("SplashKitBackendWASM.mouse_movement", "main.js")] 
      public static partial Vector2D MouseMovement();

      [JSImport("SplashKitBackendWASM.mouse_position", "main.js")] 
      public static partial Point2D MousePosition();

      [JSImport("SplashKitBackendWASM.mouse_position_vector", "main.js")] 
      public static partial Vector2D MousePositionVector();

      [JSImport("SplashKitBackendWASM.mouse_shown", "main.js")] 
      public static partial bool MouseShown();

      [JSImport("SplashKitBackendWASM.mouse_up", "main.js")] 
      public static partial bool MouseUp(MouseButton button);

      [JSImport("SplashKitBackendWASM.mouse_wheel_scroll", "main.js")] 
      public static partial Vector2D MouseWheelScroll();

      [JSImport("SplashKitBackendWASM.mouse_x", "main.js")] 
      public static partial float MouseX();

      [JSImport("SplashKitBackendWASM.mouse_y", "main.js")] 
      public static partial float MouseY();

      [JSImport("SplashKitBackendWASM.move_mouse", "main.js")] 
      public static partial void MoveMouse(double x, double y);

      [JSImport("SplashKitBackendWASM.move_mouse", "main.js")] 
      public static partial void MoveMouse(Point2D point);

      [JSImport("SplashKitBackendWASM.show_mouse", "main.js")] 
      public static partial void ShowMouse();

      [JSImport("SplashKitBackendWASM.show_mouse", "main.js")] 
      public static partial void ShowMouse(bool show);

      [JSImport("SplashKitBackendWASM.draw_collected_text", "main.js")] 
      public static partial void DrawCollectedText(Color clr, Font fnt, int fontSize, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.end_reading_text", "main.js")] 
      public static partial void EndReadingText();

      [JSImport("SplashKitBackendWASM.end_reading_text", "main.js")] 
      public static partial void EndReadingText(Window wind);

      [JSImport("SplashKitBackendWASM.reading_text", "main.js")] 
      public static partial bool ReadingText();

      [JSImport("SplashKitBackendWASM.reading_text", "main.js")] 
      public static partial bool ReadingText(Window wind);

      [JSImport("SplashKitBackendWASM.start_reading_text", "main.js")] 
      public static partial void StartReadingText(Rectangle rect);

      [JSImport("SplashKitBackendWASM.start_reading_text", "main.js")] 
      public static partial void StartReadingText(Rectangle rect, string initialText);

      [JSImport("SplashKitBackendWASM.start_reading_text", "main.js")] 
      public static partial void StartReadingText(Window wind, Rectangle rect);

      [JSImport("SplashKitBackendWASM.start_reading_text", "main.js")] 
      public static partial void StartReadingText(Window wind, Rectangle rect, string initialText);

      [JSImport("SplashKitBackendWASM.text_entry_cancelled", "main.js")] 
      public static partial bool TextEntryCancelled();

      [JSImport("SplashKitBackendWASM.text_entry_cancelled", "main.js")] 
      public static partial bool TextEntryCancelled(Window wind);

      [JSImport("SplashKitBackendWASM.text_input", "main.js")] 
      public static partial string TextInput();

      [JSImport("SplashKitBackendWASM.text_input", "main.js")] 
      public static partial string TextInput(Window wind);

      [JSImport("SplashKitBackendWASM.add_column", "main.js")] 
      public static partial void AddColumn(int width);

      [JSImport("SplashKitBackendWASM.add_column_relative", "main.js")] 
      public static partial void AddColumnRelative(double width);

      [JSImport("SplashKitBackendWASM.bitmap_button", "main.js")] 
      public static partial bool BitmapButton(Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_button", "main.js")] 
      public static partial bool BitmapButton(Bitmap bmp, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_button", "main.js")] 
      public static partial bool BitmapButton(Bitmap bmp, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.bitmap_button", "main.js")] 
      public static partial bool BitmapButton(Bitmap bmp, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.bitmap_button", "main.js")] 
      public static partial bool BitmapButton(string labelText, Bitmap bmp);

      [JSImport("SplashKitBackendWASM.bitmap_button", "main.js")] 
      public static partial bool BitmapButton(string labelText, Bitmap bmp, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.button", "main.js")] 
      public static partial bool Button(string text, Rectangle rect);

      [JSImport("SplashKitBackendWASM.button", "main.js")] 
      public static partial bool Button(string text);

      [JSImport("SplashKitBackendWASM.button", "main.js")] 
      public static partial bool Button(string labelText, string text);

      [JSImport("SplashKitBackendWASM.checkbox", "main.js")] 
      public static partial bool Checkbox(string text, bool value, Rectangle rect);

      [JSImport("SplashKitBackendWASM.checkbox", "main.js")] 
      public static partial bool Checkbox(string text, bool value);

      [JSImport("SplashKitBackendWASM.checkbox", "main.js")] 
      public static partial bool Checkbox(string labelText, string text, bool value);

      [JSImport("SplashKitBackendWASM.color_slider", "main.js")] 
      public static partial Color ColorSlider(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.color_slider", "main.js")] 
      public static partial Color ColorSlider(Color clr);

      [JSImport("SplashKitBackendWASM.color_slider", "main.js")] 
      public static partial Color ColorSlider(string labelText, Color clr);

      [JSImport("SplashKitBackendWASM.disable_interface", "main.js")] 
      public static partial void DisableInterface();

      [JSImport("SplashKitBackendWASM.draw_interface", "main.js")] 
      public static partial void DrawInterface();

      [JSImport("SplashKitBackendWASM.enable_interface", "main.js")] 
      public static partial void EnableInterface();

      [JSImport("SplashKitBackendWASM.end_inset", "main.js")] 
      public static partial void EndInset(string name);

      [JSImport("SplashKitBackendWASM.end_panel", "main.js")] 
      public static partial void EndPanel(string name);

      [JSImport("SplashKitBackendWASM.end_popup", "main.js")] 
      public static partial void EndPopup(string name);

      [JSImport("SplashKitBackendWASM.end_treenode", "main.js")] 
      public static partial void EndTreenode(string labelText);

      [JSImport("SplashKitBackendWASM.enter_column", "main.js")] 
      public static partial void EnterColumn();

      [JSImport("SplashKitBackendWASM.get_interface_label_width", "main.js")] 
      public static partial int GetInterfaceLabelWidth();

      [JSImport("SplashKitBackendWASM.header", "main.js")] 
      public static partial bool Header(string labelText);

      [JSImport("SplashKitBackendWASM.hsb_color_slider", "main.js")] 
      public static partial Color HSBColorSlider(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.hsb_color_slider", "main.js")] 
      public static partial Color HSBColorSlider(Color clr);

      [JSImport("SplashKitBackendWASM.hsb_color_slider", "main.js")] 
      public static partial Color HSBColorSlider(string labelText, Color clr);

      [JSImport("SplashKitBackendWASM.interface_enabled", "main.js")] 
      public static partial bool InterfaceEnabled();

      [JSImport("SplashKitBackendWASM.interface_style_panel", "main.js")] 
      public static partial void InterfaceStylePanel(Rectangle initialRectangle);

      [JSImport("SplashKitBackendWASM.label_element", "main.js")] 
      public static partial void LabelElement(string text);

      [JSImport("SplashKitBackendWASM.label_element", "main.js")] 
      public static partial void LabelElement(string text, Rectangle rect);

      [JSImport("SplashKitBackendWASM.last_element_changed", "main.js")] 
      public static partial bool LastElementChanged();

      [JSImport("SplashKitBackendWASM.last_element_confirmed", "main.js")] 
      public static partial bool LastElementConfirmed();

      [JSImport("SplashKitBackendWASM.leave_column", "main.js")] 
      public static partial void LeaveColumn();

      [JSImport("SplashKitBackendWASM.number_box", "main.js")] 
      public static partial float NumberBox(float value, float step, Rectangle rect);

      [JSImport("SplashKitBackendWASM.number_box", "main.js")] 
      public static partial float NumberBox(float value, float step);

      [JSImport("SplashKitBackendWASM.number_box", "main.js")] 
      public static partial float NumberBox(string labelText, float value, float step);

      [JSImport("SplashKitBackendWASM.open_popup", "main.js")] 
      public static partial void OpenPopup(string name);

      [JSImport("SplashKitBackendWASM.paragraph", "main.js")] 
      public static partial void Paragraph(string text);

      [JSImport("SplashKitBackendWASM.paragraph", "main.js")] 
      public static partial void Paragraph(string text, Rectangle rect);

      [JSImport("SplashKitBackendWASM.reset_layout", "main.js")] 
      public static partial void ResetLayout();

      [JSImport("SplashKitBackendWASM.set_interface_accent_color", "main.js")] 
      public static partial void SetInterfaceAccentColor(Color clr, float contrast);

      [JSImport("SplashKitBackendWASM.set_interface_border_color", "main.js")] 
      public static partial void SetInterfaceBorderColor(Color clr);

      [JSImport("SplashKitBackendWASM.set_interface_colors_auto", "main.js")] 
      public static partial void SetInterfaceColorsAuto(Color mainClr, Color accentClr, float contrast, float accentContrast, float borderContrast);

      [JSImport("SplashKitBackendWASM.set_interface_element_color", "main.js")] 
      public static partial void SetInterfaceElementColor(Color clr, float contrast);

      [JSImport("SplashKitBackendWASM.set_interface_element_shadows", "main.js")] 
      public static partial void SetInterfaceElementShadows(int radius, Color clr, Point2D offset);

      [JSImport("SplashKitBackendWASM.set_interface_font", "main.js")] 
      public static partial void SetInterfaceFont(string fnt);

      [JSImport("SplashKitBackendWASM.set_interface_font", "main.js")] 
      public static partial void SetInterfaceFont(Font fnt);

      [JSImport("SplashKitBackendWASM.set_interface_font_size", "main.js")] 
      public static partial void SetInterfaceFontSize(int size);

      [JSImport("SplashKitBackendWASM.set_interface_label_width", "main.js")] 
      public static partial void SetInterfaceLabelWidth(int width);

      [JSImport("SplashKitBackendWASM.set_interface_panel_shadows", "main.js")] 
      public static partial void SetInterfacePanelShadows(int radius, Color clr, Point2D offset);

      [JSImport("SplashKitBackendWASM.set_interface_root_text_color", "main.js")] 
      public static partial void SetInterfaceRootTextColor(Color clr);

      [JSImport("SplashKitBackendWASM.set_interface_shadows", "main.js")] 
      public static partial void SetInterfaceShadows(int radius, Color clr, Point2D offset);

      [JSImport("SplashKitBackendWASM.set_interface_spacing", "main.js")] 
      public static partial void SetInterfaceSpacing(int spacing, int padding);

      [JSImport("SplashKitBackendWASM.set_interface_style", "main.js")] 
      public static partial void SetInterfaceStyle(InterfaceStyle style);

      [JSImport("SplashKitBackendWASM.set_interface_style", "main.js")] 
      public static partial void SetInterfaceStyle(InterfaceStyle style, Color clr);

      [JSImport("SplashKitBackendWASM.set_interface_text_color", "main.js")] 
      public static partial void SetInterfaceTextColor(Color clr);

      [JSImport("SplashKitBackendWASM.set_layout_height", "main.js")] 
      public static partial void SetLayoutHeight(int height);

      [JSImport("SplashKitBackendWASM.single_line_layout", "main.js")] 
      public static partial void SingleLineLayout();

      [JSImport("SplashKitBackendWASM.slider", "main.js")] 
      public static partial float Slider(float value, float minValue, float maxValue, Rectangle rect);

      [JSImport("SplashKitBackendWASM.slider", "main.js")] 
      public static partial float Slider(float value, float minValue, float maxValue);

      [JSImport("SplashKitBackendWASM.slider", "main.js")] 
      public static partial float Slider(string labelText, float value, float minValue, float maxValue);

      [JSImport("SplashKitBackendWASM.split_into_columns", "main.js")] 
      public static partial void SplitIntoColumns(int count);

      [JSImport("SplashKitBackendWASM.split_into_columns", "main.js")] 
      public static partial void SplitIntoColumns(int count, int lastWidth);

      [JSImport("SplashKitBackendWASM.split_into_columns_relative", "main.js")] 
      public static partial void SplitIntoColumnsRelative(int count, double lastWidth);

      [JSImport("SplashKitBackendWASM.start_custom_layout", "main.js")] 
      public static partial void StartCustomLayout();

      [JSImport("SplashKitBackendWASM.start_inset", "main.js")] 
      public static partial void StartInset(string name, Rectangle rect);

      [JSImport("SplashKitBackendWASM.start_inset", "main.js")] 
      public static partial void StartInset(string name, int height);

      [JSImport("SplashKitBackendWASM.start_panel", "main.js")] 
      public static partial bool StartPanel(string name, Rectangle initialRectangle);

      [JSImport("SplashKitBackendWASM.start_popup", "main.js")] 
      public static partial bool StartPopup(string name);

      [JSImport("SplashKitBackendWASM.start_treenode", "main.js")] 
      public static partial bool StartTreenode(string labelText);

      [JSImport("SplashKitBackendWASM.text_box", "main.js")] 
      public static partial string TextBox(string labelText, string value, Rectangle rect);

      [JSImport("SplashKitBackendWASM.text_box", "main.js")] 
      public static partial string TextBox(string labelText, string value);

      [JSImport("SplashKitBackendWASM.text_box", "main.js")] 
      public static partial string TextBox(string labelText, string value, bool showLabel);

      [JSImport("SplashKitBackendWASM.create_json", "main.js")] 
      public static partial Json CreateJson();

      [JSImport("SplashKitBackendWASM.create_json", "main.js")] 
      public static partial Json CreateJson(string jsonString);

      [JSImport("SplashKitBackendWASM.free_all_json", "main.js")] 
      public static partial void FreeAllJson();

      [JSImport("SplashKitBackendWASM.free_json", "main.js")] 
      public static partial void FreeJson(Json j);

      [JSImport("SplashKitBackendWASM.json_count_keys", "main.js")] 
      public static partial int JsonCountKeys(Json j);

      [JSImport("SplashKitBackendWASM.json_from_color", "main.js")] 
      public static partial Json JsonFromColor(Color clr);

      [JSImport("SplashKitBackendWASM.json_from_file", "main.js")] 
      public static partial Json JsonFromFile(string filename);

      [JSImport("SplashKitBackendWASM.json_from_string", "main.js")] 
      public static partial Json JsonFromString(string jString);

      [JSImport("SplashKitBackendWASM.json_has_key", "main.js")] 
      public static partial bool JsonHasKey(Json j, string key);

      [JSImport("SplashKitBackendWASM.json_read_array", "main.js")] 
      public static partial void JsonReadArray(Json j, string key, ref List<double> outResult);

      [JSImport("SplashKitBackendWASM.json_read_array", "main.js")] 
      public static partial void JsonReadArray(Json j, string key, ref List<Json> outResult);

      [JSImport("SplashKitBackendWASM.json_read_array", "main.js")] 
      public static partial void JsonReadArray(Json j, string key, ref List<string> outResult);

      [JSImport("SplashKitBackendWASM.json_read_array", "main.js")] 
      public static partial void JsonReadArray(Json j, string key, ref List<bool> outResult);

      [JSImport("SplashKitBackendWASM.json_read_bool", "main.js")] 
      public static partial bool JsonReadBool(Json j, string key);

      [JSImport("SplashKitBackendWASM.json_read_number", "main.js")] 
      public static partial float JsonReadNumber(Json j, string key);

      [JSImport("SplashKitBackendWASM.json_read_number_as_double", "main.js")] 
      public static partial double JsonReadNumberAsDouble(Json j, string key);

      [JSImport("SplashKitBackendWASM.json_read_number_as_int", "main.js")] 
      public static partial int JsonReadNumberAsInt(Json j, string key);

      [JSImport("SplashKitBackendWASM.json_read_object", "main.js")] 
      public static partial Json JsonReadObject(Json j, string key);

      [JSImport("SplashKitBackendWASM.json_read_string", "main.js")] 
      public static partial string JsonReadString(Json j, string key);

      [JSImport("SplashKitBackendWASM.json_set_array", "main.js")] 
      public static partial void JsonSetArray(Json j, string key, List<string> value);

      [JSImport("SplashKitBackendWASM.json_set_array", "main.js")] 
      public static partial void JsonSetArray(Json j, string key, List<double> value);

      [JSImport("SplashKitBackendWASM.json_set_array", "main.js")] 
      public static partial void JsonSetArray(Json j, string key, List<bool> value);

      [JSImport("SplashKitBackendWASM.json_set_array", "main.js")] 
      public static partial void JsonSetArray(Json j, string key, List<Json> value);

      [JSImport("SplashKitBackendWASM.json_set_bool", "main.js")] 
      public static partial void JsonSetBool(Json j, string key, bool value);

      [JSImport("SplashKitBackendWASM.json_set_number", "main.js")] 
      public static partial void JsonSetNumber(Json j, string key, int value);

      [JSImport("SplashKitBackendWASM.json_set_number", "main.js")] 
      public static partial void JsonSetNumber(Json j, string key, double value);

      [JSImport("SplashKitBackendWASM.json_set_number", "main.js")] 
      public static partial void JsonSetNumber(Json j, string key, float value);

      [JSImport("SplashKitBackendWASM.json_set_object", "main.js")] 
      public static partial void JsonSetObject(Json j, string key, Json obj);

      [JSImport("SplashKitBackendWASM.json_set_string", "main.js")] 
      public static partial void JsonSetString(Json j, string key, string value);

      [JSImport("SplashKitBackendWASM.json_to_color", "main.js")] 
      public static partial Color JsonToColor(Json j);

      [JSImport("SplashKitBackendWASM.json_to_file", "main.js")] 
      public static partial void JsonToFile(Json j, string filename);

      [JSImport("SplashKitBackendWASM.json_to_string", "main.js")] 
      public static partial string JsonToString(Json j);

      [JSImport("SplashKitBackendWASM.close_log_process", "main.js")] 
      public static partial void CloseLogProcess();

      [JSImport("SplashKitBackendWASM.init_custom_logger", "main.js")] 
      public static partial void InitCustomLogger(LogMode mode);

      [JSImport("SplashKitBackendWASM.init_custom_logger", "main.js")] 
      public static partial void InitCustomLogger(string appName, bool overridePrevLog, LogMode mode);

      [JSImport("SplashKitBackendWASM.log", "main.js")] 
      public static partial void Log(LogLevel level, string message);

      [JSImport("SplashKitBackendWASM.accept_all_new_connections", "main.js")] 
      public static partial bool AcceptAllNewConnections();

      [JSImport("SplashKitBackendWASM.accept_new_connection", "main.js")] 
      public static partial bool AcceptNewConnection(ServerSocket server);

      [JSImport("SplashKitBackendWASM.broadcast_message", "main.js")] 
      public static partial void BroadcastMessage(string aMsg, ServerSocket svr);

      [JSImport("SplashKitBackendWASM.broadcast_message", "main.js")] 
      public static partial void BroadcastMessage(string aMsg);

      [JSImport("SplashKitBackendWASM.broadcast_message", "main.js")] 
      public static partial void BroadcastMessage(string aMsg, string name);

      [JSImport("SplashKitBackendWASM.check_network_activity", "main.js")] 
      public static partial void CheckNetworkActivity();

      [JSImport("SplashKitBackendWASM.clear_messages", "main.js")] 
      public static partial void ClearMessages(string name);

      [JSImport("SplashKitBackendWASM.clear_messages", "main.js")] 
      public static partial void ClearMessages(Connection aConnection);

      [JSImport("SplashKitBackendWASM.clear_messages", "main.js")] 
      public static partial void ClearMessages(ServerSocket svr);

      [JSImport("SplashKitBackendWASM.close_all_connections", "main.js")] 
      public static partial void CloseAllConnections();

      [JSImport("SplashKitBackendWASM.close_all_servers", "main.js")] 
      public static partial void CloseAllServers();

      [JSImport("SplashKitBackendWASM.close_connection", "main.js")] 
      public static partial bool CloseConnection(Connection aConnection);

      [JSImport("SplashKitBackendWASM.close_connection", "main.js")] 
      public static partial bool CloseConnection(string name);

      [JSImport("SplashKitBackendWASM.close_message", "main.js")] 
      public static partial void CloseMessage(Message msg);

      [JSImport("SplashKitBackendWASM.close_server", "main.js")] 
      public static partial bool CloseServer(string name);

      [JSImport("SplashKitBackendWASM.close_server", "main.js")] 
      public static partial bool CloseServer(ServerSocket svr);

      [JSImport("SplashKitBackendWASM.connection_count", "main.js")] 
      public static partial uint ConnectionCount(string name);

      [JSImport("SplashKitBackendWASM.connection_count", "main.js")] 
      public static partial uint ConnectionCount(ServerSocket server);

      [JSImport("SplashKitBackendWASM.connection_ip", "main.js")] 
      public static partial uint ConnectionIP(Connection aConnection);

      [JSImport("SplashKitBackendWASM.connection_ip", "main.js")] 
      public static partial uint ConnectionIP(string name);

      [JSImport("SplashKitBackendWASM.connection_named", "main.js")] 
      public static partial Connection ConnectionNamed(string name);

      [JSImport("SplashKitBackendWASM.connection_port", "main.js")] 
      public static partial ushort ConnectionPort(Connection aConnection);

      [JSImport("SplashKitBackendWASM.connection_port", "main.js")] 
      public static partial ushort ConnectionPort(string name);

      [JSImport("SplashKitBackendWASM.create_server", "main.js")] 
      public static partial ServerSocket CreateServer(string name, ushort port);

      [JSImport("SplashKitBackendWASM.create_server", "main.js")] 
      public static partial ServerSocket CreateServer(string name, ushort port, ConnectionType protocol);

      [JSImport("SplashKitBackendWASM.dec_to_hex", "main.js")] 
      public static partial string DecToHex(uint aDec);

      [JSImport("SplashKitBackendWASM.dec_to_ipv4", "main.js")] 
      public static partial string DecToIpv4(uint ip);

      [JSImport("SplashKitBackendWASM.fetch_new_connection", "main.js")] 
      public static partial Connection FetchNewConnection(ServerSocket server);

      [JSImport("SplashKitBackendWASM.has_connection", "main.js")] 
      public static partial bool HasConnection(string name);

      [JSImport("SplashKitBackendWASM.has_messages", "main.js")] 
      public static partial bool HasMessages();

      [JSImport("SplashKitBackendWASM.has_messages", "main.js")] 
      public static partial bool HasMessages(Connection con);

      [JSImport("SplashKitBackendWASM.has_messages", "main.js")] 
      public static partial bool HasMessages(string name);

      [JSImport("SplashKitBackendWASM.has_messages", "main.js")] 
      public static partial bool HasMessages(ServerSocket svr);

      [JSImport("SplashKitBackendWASM.has_new_connections", "main.js")] 
      public static partial bool HasNewConnections();

      [JSImport("SplashKitBackendWASM.has_server", "main.js")] 
      public static partial bool HasServer(string name);

      [JSImport("SplashKitBackendWASM.hex_str_to_ipv4", "main.js")] 
      public static partial string HexStrToIpv4(string aHex);

      [JSImport("SplashKitBackendWASM.hex_to_dec_string", "main.js")] 
      public static partial string HexToDecString(string aHex);

      [JSImport("SplashKitBackendWASM.hex_to_mac", "main.js")] 
      public static partial string HexToMac(string hexStr);

      [JSImport("SplashKitBackendWASM.ipv4_to_dec", "main.js")] 
      public static partial uint Ipv4ToDec(string aIP);

      [JSImport("SplashKitBackendWASM.ipv4_to_hex", "main.js")] 
      public static partial string Ipv4ToHex(string aIP);

      [JSImport("SplashKitBackendWASM.is_connection_open", "main.js")] 
      public static partial bool IsConnectionOpen(Connection con);

      [JSImport("SplashKitBackendWASM.is_connection_open", "main.js")] 
      public static partial bool IsConnectionOpen(string name);

      [JSImport("SplashKitBackendWASM.is_valid_ipv4", "main.js")] 
      public static partial bool IsValidIpv4(string ip);

      [JSImport("SplashKitBackendWASM.is_valid_mac", "main.js")] 
      public static partial bool IsValidMac(string macAddress);

      [JSImport("SplashKitBackendWASM.last_connection", "main.js")] 
      public static partial Connection LastConnection(string name);

      [JSImport("SplashKitBackendWASM.last_connection", "main.js")] 
      public static partial Connection LastConnection(ServerSocket server);

      [JSImport("SplashKitBackendWASM.mac_to_hex", "main.js")] 
      public static partial string MacToHex(string macAddress);

      [JSImport("SplashKitBackendWASM.message_connection", "main.js")] 
      public static partial Connection MessageConnection(Message msg);

      [JSImport("SplashKitBackendWASM.message_count", "main.js")] 
      public static partial uint MessageCount(ServerSocket svr);

      [JSImport("SplashKitBackendWASM.message_count", "main.js")] 
      public static partial uint MessageCount(Connection aConnection);

      [JSImport("SplashKitBackendWASM.message_count", "main.js")] 
      public static partial uint MessageCount(string name);

      [JSImport("SplashKitBackendWASM.message_data", "main.js")] 
      public static partial string MessageData(Message msg);

      [JSImport("SplashKitBackendWASM.message_data_bytes", "main.js")] 
      public static partial List<byte> MessageDataBytes(Message msg);

      [JSImport("SplashKitBackendWASM.message_host", "main.js")] 
      public static partial string MessageHost(Message msg);

      [JSImport("SplashKitBackendWASM.message_port", "main.js")] 
      public static partial ushort MessagePort(Message msg);

      [JSImport("SplashKitBackendWASM.message_protocol", "main.js")] 
      public static partial ConnectionType MessageProtocol(Message msg);

      [JSImport("SplashKitBackendWASM.my_ip", "main.js")] 
      public static partial string MyIP();

      [JSImport("SplashKitBackendWASM.name_for_connection", "main.js")] 
      public static partial string NameForConnection(string host, uint port);

      [JSImport("SplashKitBackendWASM.new_connection_count", "main.js")] 
      public static partial int NewConnectionCount(ServerSocket server);

      [JSImport("SplashKitBackendWASM.open_connection", "main.js")] 
      public static partial Connection OpenConnection(string name, string host, ushort port);

      [JSImport("SplashKitBackendWASM.open_connection", "main.js")] 
      public static partial Connection OpenConnection(string name, string host, ushort port, ConnectionType protocol);

      [JSImport("SplashKitBackendWASM.read_message", "main.js")] 
      public static partial Message ReadMessage();

      [JSImport("SplashKitBackendWASM.read_message", "main.js")] 
      public static partial Message ReadMessage(Connection aConnection);

      [JSImport("SplashKitBackendWASM.read_message", "main.js")] 
      public static partial Message ReadMessage(string name);

      [JSImport("SplashKitBackendWASM.read_message", "main.js")] 
      public static partial Message ReadMessage(ServerSocket svr);

      [JSImport("SplashKitBackendWASM.read_message_data", "main.js")] 
      public static partial string ReadMessageData(string name);

      [JSImport("SplashKitBackendWASM.read_message_data", "main.js")] 
      public static partial string ReadMessageData(Connection aConnection);

      [JSImport("SplashKitBackendWASM.read_message_data", "main.js")] 
      public static partial string ReadMessageData(ServerSocket svr);

      [JSImport("SplashKitBackendWASM.reconnect", "main.js")] 
      public static partial void Reconnect(Connection aConnection);

      [JSImport("SplashKitBackendWASM.reconnect", "main.js")] 
      public static partial void Reconnect(string name);

      [JSImport("SplashKitBackendWASM.release_all_connections", "main.js")] 
      public static partial void ReleaseAllConnections();

      [JSImport("SplashKitBackendWASM.reset_new_connection_count", "main.js")] 
      public static partial void ResetNewConnectionCount(ServerSocket server);

      [JSImport("SplashKitBackendWASM.retrieve_connection", "main.js")] 
      public static partial Connection RetrieveConnection(string name, int idx);

      [JSImport("SplashKitBackendWASM.retrieve_connection", "main.js")] 
      public static partial Connection RetrieveConnection(ServerSocket server, int idx);

      [JSImport("SplashKitBackendWASM.send_message_to", "main.js")] 
      public static partial bool SendMessageTo(string aMsg, Connection aConnection);

      [JSImport("SplashKitBackendWASM.send_message_to", "main.js")] 
      public static partial bool SendMessageTo(string aMsg, string name);

      [JSImport("SplashKitBackendWASM.server_has_new_connection", "main.js")] 
      public static partial bool ServerHasNewConnection(string name);

      [JSImport("SplashKitBackendWASM.server_has_new_connection", "main.js")] 
      public static partial bool ServerHasNewConnection(ServerSocket server);

      [JSImport("SplashKitBackendWASM.server_named", "main.js")] 
      public static partial ServerSocket ServerNamed(string name);

      [JSImport("SplashKitBackendWASM.set_udp_packet_size", "main.js")] 
      public static partial void SetUDPPacketSize(uint udpPacketSize);

      [JSImport("SplashKitBackendWASM.udp_packet_size", "main.js")] 
      public static partial uint UDPPacketSize();

      [JSImport("SplashKitBackendWASM.download_bitmap", "main.js")] 
      public static partial Bitmap DownloadBitmap(string name, string url, ushort port);

      [JSImport("SplashKitBackendWASM.download_font", "main.js")] 
      public static partial Font DownloadFont(string name, string url, ushort port);

      [JSImport("SplashKitBackendWASM.download_music", "main.js")] 
      public static partial Music DownloadMusic(string name, string url, ushort port);

      [JSImport("SplashKitBackendWASM.download_sound_effect", "main.js")] 
      public static partial SoundEffect DownloadSoundEffect(string name, string url, ushort port);

      [JSImport("SplashKitBackendWASM.free_response", "main.js")] 
      public static partial void FreeResponse(HttpResponse response);

      [JSImport("SplashKitBackendWASM.http_get", "main.js")] 
      public static partial HttpResponse HttpGet(string url, ushort port);

      [JSImport("SplashKitBackendWASM.http_post", "main.js")] 
      public static partial HttpResponse HttpPost(string url, ushort port, string body, List<string> headers);

      [JSImport("SplashKitBackendWASM.http_post", "main.js")] 
      public static partial HttpResponse HttpPost(string url, ushort port, string body);

      [JSImport("SplashKitBackendWASM.http_response_to_string", "main.js")] 
      public static partial string HttpResponseToString(HttpResponse response);

      [JSImport("SplashKitBackendWASM.save_response_to_file", "main.js")] 
      public static partial void SaveResponseToFile(HttpResponse response, string path);

      [JSImport("SplashKitBackendWASM.has_incoming_requests", "main.js")] 
      public static partial bool HasIncomingRequests(WebServer server);

      [JSImport("SplashKitBackendWASM.is_delete_request_for", "main.js")] 
      public static partial bool IsDeleteRequestFor(HttpRequest request, string path);

      [JSImport("SplashKitBackendWASM.is_get_request_for", "main.js")] 
      public static partial bool IsGetRequestFor(HttpRequest request, string path);

      [JSImport("SplashKitBackendWASM.is_options_request_for", "main.js")] 
      public static partial bool IsOptionsRequestFor(HttpRequest request, string path);

      [JSImport("SplashKitBackendWASM.is_post_request_for", "main.js")] 
      public static partial bool IsPostRequestFor(HttpRequest request, string path);

      [JSImport("SplashKitBackendWASM.is_put_request_for", "main.js")] 
      public static partial bool IsPutRequestFor(HttpRequest request, string path);

      [JSImport("SplashKitBackendWASM.is_request_for", "main.js")] 
      public static partial bool IsRequestFor(HttpRequest request, HttpMethod method, string path);

      [JSImport("SplashKitBackendWASM.is_trace_request_for", "main.js")] 
      public static partial bool IsTraceRequestFor(HttpRequest request, string path);

      [JSImport("SplashKitBackendWASM.next_web_request", "main.js")] 
      public static partial HttpRequest NextWebRequest(WebServer server);

      [JSImport("SplashKitBackendWASM.request_body", "main.js")] 
      public static partial string RequestBody(HttpRequest r);

      [JSImport("SplashKitBackendWASM.request_has_query_parameter", "main.js")] 
      public static partial bool RequestHasQueryParameter(HttpRequest r, string name);

      [JSImport("SplashKitBackendWASM.request_headers", "main.js")] 
      public static partial List<string> RequestHeaders(HttpRequest r);

      [JSImport("SplashKitBackendWASM.request_method", "main.js")] 
      public static partial HttpMethod RequestMethod(HttpRequest r);

      [JSImport("SplashKitBackendWASM.request_query_parameter", "main.js")] 
      public static partial string RequestQueryParameter(HttpRequest r, string name, string defaultValue);

      [JSImport("SplashKitBackendWASM.request_query_string", "main.js")] 
      public static partial string RequestQueryString(HttpRequest r);

      [JSImport("SplashKitBackendWASM.request_uri", "main.js")] 
      public static partial string RequestURI(HttpRequest r);

      [JSImport("SplashKitBackendWASM.request_uri_stubs", "main.js")] 
      public static partial List<string> RequestURIStubs(HttpRequest r);

      [JSImport("SplashKitBackendWASM.send_css_file_response", "main.js")] 
      public static partial void SendCSSFileResponse(HttpRequest r, string filename);

      [JSImport("SplashKitBackendWASM.send_file_response", "main.js")] 
      public static partial void SendFileResponse(HttpRequest r, string filename, string contentType);

      [JSImport("SplashKitBackendWASM.send_html_file_response", "main.js")] 
      public static partial void SendHtmlFileResponse(HttpRequest r, string filename);

      [JSImport("SplashKitBackendWASM.send_javascript_file_response", "main.js")] 
      public static partial void SendJavascriptFileResponse(HttpRequest r, string filename);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public static partial void SendResponse(HttpRequest r);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public static partial void SendResponse(HttpRequest r, string message);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public static partial void SendResponse(HttpRequest r, HttpStatusCode code);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public static partial void SendResponse(HttpRequest r, HttpStatusCode code, string message);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public static partial void SendResponse(HttpRequest r, HttpStatusCode code, string message, string contentType);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public static partial void SendResponse(HttpRequest r, HttpStatusCode code, string message, string contentType, List<string> headers);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public static partial void SendResponse(HttpRequest r, Json j);

      [JSImport("SplashKitBackendWASM.split_uri_stubs", "main.js")] 
      public static partial List<string> SplitURIStubs(string uri);

      [JSImport("SplashKitBackendWASM.start_web_server", "main.js")] 
      public static partial WebServer StartWebServer();

      [JSImport("SplashKitBackendWASM.start_web_server", "main.js")] 
      public static partial WebServer StartWebServer(ushort port);

      [JSImport("SplashKitBackendWASM.stop_web_server", "main.js")] 
      public static partial void StopWebServer(WebServer server);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public static partial bool BitmapCircleCollision(Bitmap bmp, Point2D pt, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public static partial bool BitmapCircleCollision(Bitmap bmp, double x, double y, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public static partial bool BitmapCircleCollision(Bitmap bmp, int cell, Matrix2D translation, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public static partial bool BitmapCircleCollision(Bitmap bmp, int cell, Point2D pt, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public static partial bool BitmapCircleCollision(Bitmap bmp, int cell, double x, double y, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public static partial bool BitmapCollision(Bitmap bmp1, double x1, double y1, Bitmap bmp2, double x2, double y2);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public static partial bool BitmapCollision(Bitmap bmp1, Point2D pt1, Bitmap bmp2, Point2D pt2);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public static partial bool BitmapCollision(Bitmap bmp1, int cell1, Matrix2D matrix1, Bitmap bmp2, int cell2, Matrix2D matrix2);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public static partial bool BitmapCollision(Bitmap bmp1, int cell1, Point2D pt1, Bitmap bmp2, int cell2, Point2D pt2);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public static partial bool BitmapCollision(Bitmap bmp1, int cell1, double x1, double y1, Bitmap bmp2, int cell2, double x2, double y2);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public static partial bool BitmapPointCollision(Bitmap bmp, Matrix2D translation, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public static partial bool BitmapPointCollision(Bitmap bmp, Point2D bmpPt, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public static partial bool BitmapPointCollision(Bitmap bmp, double bmpX, double bmpY, double x, double y);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public static partial bool BitmapPointCollision(Bitmap bmp, int cell, Matrix2D translation, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public static partial bool BitmapPointCollision(Bitmap bmp, int cell, Point2D bmpPt, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public static partial bool BitmapPointCollision(Bitmap bmp, int cell, double bmpX, double bmpY, double x, double y);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public static partial bool BitmapQuadCollision(Bitmap bmp, Point2D pt, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public static partial bool BitmapQuadCollision(Bitmap bmp, double x, double y, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public static partial bool BitmapQuadCollision(Bitmap bmp, int cell, Matrix2D translation, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public static partial bool BitmapQuadCollision(Bitmap bmp, int cell, Point2D pt, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public static partial bool BitmapQuadCollision(Bitmap bmp, int cell, double x, double y, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public static partial bool BitmapRayCollision(Bitmap bmp, Point2D pt, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public static partial bool BitmapRayCollision(Bitmap bmp, double x, double y, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public static partial bool BitmapRayCollision(Bitmap bmp, int cell, Matrix2D translation, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public static partial bool BitmapRayCollision(Bitmap bmp, int cell, Point2D pt, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public static partial bool BitmapRayCollision(Bitmap bmp, int cell, double x, double y, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public static partial bool BitmapRectangleCollision(Bitmap bmp, Point2D pt, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public static partial bool BitmapRectangleCollision(Bitmap bmp, double x, double y, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public static partial bool BitmapRectangleCollision(Bitmap bmp, int cell, Matrix2D translation, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public static partial bool BitmapRectangleCollision(Bitmap bmp, int cell, Point2D pt, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public static partial bool BitmapRectangleCollision(Bitmap bmp, int cell, double x, double y, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public static partial bool BitmapTriangleCollision(Bitmap bmp, Point2D pt, Triangle tri);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public static partial bool BitmapTriangleCollision(Bitmap bmp, double x, double y, Triangle tri);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public static partial bool BitmapTriangleCollision(Bitmap bmp, int cell, Matrix2D translation, Triangle tri);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public static partial bool BitmapTriangleCollision(Bitmap bmp, int cell, Point2D pt, Triangle tri);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public static partial bool BitmapTriangleCollision(Bitmap bmp, int cell, double x, double y, Triangle tri);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Quad collider, Quad collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Circle collider, Circle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Circle collider, Quad collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Circle collider, Rectangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Circle collider, Sprite collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Circle collider, Triangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Quad collider, Circle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Quad collider, Rectangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Quad collider, Sprite collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Quad collider, Triangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Rectangle collider, Circle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Rectangle collider, Quad collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Rectangle collider, Rectangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Rectangle collider, Sprite collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Rectangle collider, Triangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Sprite collider, Circle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Sprite collider, Quad collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Sprite collider, Rectangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Sprite collider, Sprite collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Sprite collider, Triangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Triangle collider, Circle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Triangle collider, Quad collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Triangle collider, Rectangle collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Triangle collider, Sprite collidee);

      [JSImport("SplashKitBackendWASM.calculate_collision_direction", "main.js")] 
      public static partial Vector2D CalculateCollisionDirection(Triangle collider, Triangle collidee);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Quad collider, Quad collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Circle collider, Circle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Circle collider, Quad collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Circle collider, Rectangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Circle collider, Sprite collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Circle collider, Triangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Quad collider, Circle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Quad collider, Rectangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Quad collider, Sprite collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Quad collider, Triangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Rectangle collider, Circle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Rectangle collider, Quad collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Rectangle collider, Rectangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Rectangle collider, Sprite collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Rectangle collider, Triangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(Sprite collider, Circle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(Sprite collider, Quad collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(Sprite collider, Rectangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(Sprite collider, Sprite collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(Sprite collider, Triangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Triangle collider, Circle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Triangle collider, Quad collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Triangle collider, Rectangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Triangle collider, Sprite collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.resolve_collision", "main.js")] 
      public static partial bool ResolveCollision(ref Triangle collider, Triangle collidee, Vector2D direction);

      [JSImport("SplashKitBackendWASM.sprite_bitmap_collision", "main.js")] 
      public static partial bool SpriteBitmapCollision(Sprite s, Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.sprite_bitmap_collision", "main.js")] 
      public static partial bool SpriteBitmapCollision(Sprite s, Bitmap bmp, int cell, Point2D pt);

      [JSImport("SplashKitBackendWASM.sprite_bitmap_collision", "main.js")] 
      public static partial bool SpriteBitmapCollision(Sprite s, Bitmap bmp, int cell, double x, double y);

      [JSImport("SplashKitBackendWASM.sprite_circle_collision", "main.js")] 
      public static partial bool SpriteCircleCollision(Sprite s, Circle c);

      [JSImport("SplashKitBackendWASM.sprite_collision", "main.js")] 
      public static partial bool SpriteCollision(Sprite s1, Sprite s2);

      [JSImport("SplashKitBackendWASM.sprite_point_collision", "main.js")] 
      public static partial bool SpritePointCollision(Sprite s, Point2D pt);

      [JSImport("SplashKitBackendWASM.sprite_quad_collision", "main.js")] 
      public static partial bool SpriteQuadCollision(Sprite s, Quad q);

      [JSImport("SplashKitBackendWASM.sprite_ray_collision", "main.js")] 
      public static partial bool SpriteRayCollision(Sprite s, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.sprite_rectangle_collision", "main.js")] 
      public static partial bool SpriteRectangleCollision(Sprite s, Rectangle rect);

      [JSImport("SplashKitBackendWASM.sprite_triangle_collision", "main.js")] 
      public static partial bool SpriteTriangleCollision(Sprite s, Triangle t);

      [JSImport("SplashKitBackendWASM.apply_matrix", "main.js")] 
      public static partial void ApplyMatrix(Matrix2D matrix, ref Quad q);

      [JSImport("SplashKitBackendWASM.apply_matrix", "main.js")] 
      public static partial void ApplyMatrix(Matrix2D m, ref Triangle tri);

      [JSImport("SplashKitBackendWASM.identity_matrix", "main.js")] 
      public static partial Matrix2D IdentityMatrix();

      [JSImport("SplashKitBackendWASM.matrix_inverse", "main.js")] 
      public static partial Matrix2D MatrixInverse(Matrix2D m);

      [JSImport("SplashKitBackendWASM.matrix_multiply", "main.js")] 
      public static partial Point2D MatrixMultiply(Matrix2D m, Point2D pt);

      [JSImport("SplashKitBackendWASM.matrix_multiply", "main.js")] 
      public static partial Matrix2D MatrixMultiply(Matrix2D m1, Matrix2D m2);

      [JSImport("SplashKitBackendWASM.matrix_multiply", "main.js")] 
      public static partial Vector2D MatrixMultiply(Matrix2D m, Vector2D v);

      [JSImport("SplashKitBackendWASM.matrix_to_string", "main.js")] 
      public static partial string MatrixToString(Matrix2D matrix);

      [JSImport("SplashKitBackendWASM.rotation_matrix", "main.js")] 
      public static partial Matrix2D RotationMatrix(double deg);

      [JSImport("SplashKitBackendWASM.scale_matrix", "main.js")] 
      public static partial Matrix2D ScaleMatrix(Point2D scale);

      [JSImport("SplashKitBackendWASM.scale_matrix", "main.js")] 
      public static partial Matrix2D ScaleMatrix(Vector2D scale);

      [JSImport("SplashKitBackendWASM.scale_matrix", "main.js")] 
      public static partial Matrix2D ScaleMatrix(double scale);

      [JSImport("SplashKitBackendWASM.scale_rotate_translate_matrix", "main.js")] 
      public static partial Matrix2D ScaleRotateTranslateMatrix(Point2D scale, double deg, Point2D translate);

      [JSImport("SplashKitBackendWASM.translation_matrix", "main.js")] 
      public static partial Matrix2D TranslationMatrix(Point2D pt);

      [JSImport("SplashKitBackendWASM.translation_matrix", "main.js")] 
      public static partial Matrix2D TranslationMatrix(Vector2D pt);

      [JSImport("SplashKitBackendWASM.translation_matrix", "main.js")] 
      public static partial Matrix2D TranslationMatrix(double dx, double dy);

      [JSImport("SplashKitBackendWASM.angle_between", "main.js")] 
      public static partial double AngleBetween(Vector2D v1, Vector2D v2);

      [JSImport("SplashKitBackendWASM.dot_product", "main.js")] 
      public static partial double DotProduct(Vector2D v1, Vector2D v2);

      [JSImport("SplashKitBackendWASM.is_zero_vector", "main.js")] 
      public static partial bool IsZeroVector(Vector2D v);

      [JSImport("SplashKitBackendWASM.ray_intersection_point", "main.js")] 
      public static partial bool RayIntersectionPoint(Point2D fromPt, Vector2D heading, Line l, ref Point2D pt);

      [JSImport("SplashKitBackendWASM.unit_vector", "main.js")] 
      public static partial Vector2D UnitVector(Vector2D v);

      [JSImport("SplashKitBackendWASM.vector_add", "main.js")] 
      public static partial Vector2D VectorAdd(Vector2D v1, Vector2D v2);

      [JSImport("SplashKitBackendWASM.vector_angle", "main.js")] 
      public static partial double VectorAngle(Vector2D v);

      [JSImport("SplashKitBackendWASM.vector_from_angle", "main.js")] 
      public static partial Vector2D VectorFromAngle(double angle, double magnitude);

      [JSImport("SplashKitBackendWASM.vector_from_line", "main.js")] 
      public static partial Vector2D VectorFromLine(Line l);

      [JSImport("SplashKitBackendWASM.vector_from_point_to_rect", "main.js")] 
      public static partial Vector2D VectorFromPointToRect(Point2D pt, Rectangle rect);

      [JSImport("SplashKitBackendWASM.vector_in_rect", "main.js")] 
      public static partial bool VectorInRect(Vector2D v, Rectangle rect);

      [JSImport("SplashKitBackendWASM.vector_invert", "main.js")] 
      public static partial Vector2D VectorInvert(Vector2D v);

      [JSImport("SplashKitBackendWASM.vector_limit", "main.js")] 
      public static partial Vector2D VectorLimit(Vector2D v, double limit);

      [JSImport("SplashKitBackendWASM.vector_magnitude", "main.js")] 
      public static partial double VectorMagnitude(Vector2D v);

      [JSImport("SplashKitBackendWASM.vector_magnitude_squared", "main.js")] 
      public static partial double VectorMagnitudeSquared(Vector2D v);

      [JSImport("SplashKitBackendWASM.vector_multiply", "main.js")] 
      public static partial Vector2D VectorMultiply(Vector2D v1, double s);

      [JSImport("SplashKitBackendWASM.vector_normal", "main.js")] 
      public static partial Vector2D VectorNormal(Vector2D v);

      [JSImport("SplashKitBackendWASM.vector_out_of_circle_from_circle", "main.js")] 
      public static partial Vector2D VectorOutOfCircleFromCircle(Circle src, Circle bounds, Vector2D velocity);

      [JSImport("SplashKitBackendWASM.vector_out_of_circle_from_point", "main.js")] 
      public static partial Vector2D VectorOutOfCircleFromPoint(Point2D pt, Circle c, Vector2D velocity);

      [JSImport("SplashKitBackendWASM.vector_out_of_rect_from_circle", "main.js")] 
      public static partial Vector2D VectorOutOfRectFromCircle(Circle c, Rectangle rect, Vector2D velocity);

      [JSImport("SplashKitBackendWASM.vector_out_of_rect_from_point", "main.js")] 
      public static partial Vector2D VectorOutOfRectFromPoint(Point2D pt, Rectangle rect, Vector2D velocity);

      [JSImport("SplashKitBackendWASM.vector_out_of_rect_from_rect", "main.js")] 
      public static partial Vector2D VectorOutOfRectFromRect(Rectangle src, Rectangle bounds, Vector2D velocity);

      [JSImport("SplashKitBackendWASM.vector_point_to_point", "main.js")] 
      public static partial Vector2D VectorPointToPoint(Point2D start, Point2D endPt);

      [JSImport("SplashKitBackendWASM.vector_subtract", "main.js")] 
      public static partial Vector2D VectorSubtract(Vector2D v1, Vector2D v2);

      [JSImport("SplashKitBackendWASM.vector_to", "main.js")] 
      public static partial Vector2D VectorTo(Point2D p1);

      [JSImport("SplashKitBackendWASM.vector_to", "main.js")] 
      public static partial Vector2D VectorTo(double x, double y);

      [JSImport("SplashKitBackendWASM.vector_to_string", "main.js")] 
      public static partial string VectorToString(Vector2D v);

      [JSImport("SplashKitBackendWASM.vectors_equal", "main.js")] 
      public static partial bool VectorsEqual(Vector2D v1, Vector2D v2);

      [JSImport("SplashKitBackendWASM.vectors_not_equal", "main.js")] 
      public static partial bool VectorsNotEqual(Vector2D v1, Vector2D v2);

      [JSImport("SplashKitBackendWASM.adc_device_named", "main.js")] 
      public static partial AdcDevice AdcDeviceNamed(string name);

      [JSImport("SplashKitBackendWASM.close_adc", "main.js")] 
      public static partial void CloseAdc(AdcDevice adc);

      [JSImport("SplashKitBackendWASM.close_adc", "main.js")] 
      public static partial void CloseAdc(string name);

      [JSImport("SplashKitBackendWASM.close_all_adc", "main.js")] 
      public static partial void CloseAllAdc();

      [JSImport("SplashKitBackendWASM.has_adc_device", "main.js")] 
      public static partial bool HasAdcDevice(string name);

      [JSImport("SplashKitBackendWASM.open_adc", "main.js")] 
      public static partial AdcDevice OpenAdc(string name, AdcType type);

      [JSImport("SplashKitBackendWASM.open_adc", "main.js")] 
      public static partial AdcDevice OpenAdc(string name, int bus, int address, AdcType type);

      [JSImport("SplashKitBackendWASM.read_adc", "main.js")] 
      public static partial int ReadAdc(AdcDevice adc, AdcPin channel);

      [JSImport("SplashKitBackendWASM.read_adc", "main.js")] 
      public static partial int ReadAdc(string name, AdcPin channel);

      [JSImport("SplashKitBackendWASM.has_gpio", "main.js")] 
      public static partial bool HasGpio();

      [JSImport("SplashKitBackendWASM.raspi_cleanup", "main.js")] 
      public static partial void RaspiCleanup();

      [JSImport("SplashKitBackendWASM.raspi_get_mode", "main.js")] 
      public static partial GpioPinMode RaspiGetMode(GpioPin pin);

      [JSImport("SplashKitBackendWASM.raspi_get_servo_pulsewidth", "main.js")] 
      public static partial int RaspiGetServoPulsewidth(GpioPin pin);

      [JSImport("SplashKitBackendWASM.raspi_init", "main.js")] 
      public static partial void RaspiInit();

      [JSImport("SplashKitBackendWASM.raspi_read", "main.js")] 
      public static partial GpioPinValue RaspiRead(GpioPin pin);

      [JSImport("SplashKitBackendWASM.raspi_set_mode", "main.js")] 
      public static partial void RaspiSetMode(GpioPin pin, GpioPinMode mode);

      [JSImport("SplashKitBackendWASM.raspi_set_pull_up_down", "main.js")] 
      public static partial void RaspiSetPullUpDown(GpioPin pin, PullUpDown pud);

      [JSImport("SplashKitBackendWASM.raspi_set_pwm_dutycycle", "main.js")] 
      public static partial void RaspiSetPwmDutycycle(GpioPin pin, int dutycycle);

      [JSImport("SplashKitBackendWASM.raspi_set_pwm_frequency", "main.js")] 
      public static partial void RaspiSetPwmFrequency(GpioPin pin, int frequency);

      [JSImport("SplashKitBackendWASM.raspi_set_pwm_range", "main.js")] 
      public static partial void RaspiSetPwmRange(GpioPin pin, int range);

      [JSImport("SplashKitBackendWASM.raspi_set_servo_pulsewidth", "main.js")] 
      public static partial void RaspiSetServoPulsewidth(GpioPin pin, int pulsewidth);

      [JSImport("SplashKitBackendWASM.raspi_spi_close", "main.js")] 
      public static partial int RaspiSpiClose(int handle);

      [JSImport("SplashKitBackendWASM.raspi_spi_open", "main.js")] 
      public static partial int RaspiSpiOpen(int channel, int speed, int spiFlags);

      [JSImport("SplashKitBackendWASM.raspi_spi_transfer", "main.js")] 
      public static partial string RaspiSpiTransfer(int handle, string send, int count, ref int bytesTransfered);

      [JSImport("SplashKitBackendWASM.raspi_write", "main.js")] 
      public static partial void RaspiWrite(GpioPin pin, GpioPinValue value);

      [JSImport("SplashKitBackendWASM.remote_raspi_cleanup", "main.js")] 
      public static partial bool RemoteRaspiCleanup(Connection pi);

      [JSImport("SplashKitBackendWASM.remote_raspi_get_mode", "main.js")] 
      public static partial GpioPinMode RemoteRaspiGetMode(Connection pi, GpioPin pin);

      [JSImport("SplashKitBackendWASM.remote_raspi_init", "main.js")] 
      public static partial Connection RemoteRaspiInit(string name, string host, ushort port);

      [JSImport("SplashKitBackendWASM.remote_raspi_read", "main.js")] 
      public static partial GpioPinValue RemoteRaspiRead(Connection pi, GpioPin pin);

      [JSImport("SplashKitBackendWASM.remote_raspi_set_mode", "main.js")] 
      public static partial void RemoteRaspiSetMode(Connection pi, GpioPin pin, GpioPinMode mode);

      [JSImport("SplashKitBackendWASM.remote_raspi_set_pull_up_down", "main.js")] 
      public static partial void RemoteRaspiSetPullUpDown(Connection pi, GpioPin pin, PullUpDown pud);

      [JSImport("SplashKitBackendWASM.remote_raspi_set_pwm_dutycycle", "main.js")] 
      public static partial void RemoteRaspiSetPwmDutycycle(Connection pi, GpioPin pin, int dutycycle);

      [JSImport("SplashKitBackendWASM.remote_raspi_set_pwm_frequency", "main.js")] 
      public static partial void RemoteRaspiSetPwmFrequency(Connection pi, GpioPin pin, int frequency);

      [JSImport("SplashKitBackendWASM.remote_raspi_set_pwm_range", "main.js")] 
      public static partial void RemoteRaspiSetPwmRange(Connection pi, GpioPin pin, int range);

      [JSImport("SplashKitBackendWASM.remote_raspi_write", "main.js")] 
      public static partial void RemoteRaspiWrite(Connection pi, GpioPin pin, GpioPinValue value);

      [JSImport("SplashKitBackendWASM.to_int", "main.js")] 
      public static partial int ToInt(GpioPinValue value);

      [JSImport("SplashKitBackendWASM.free_resource_bundle", "main.js")] 
      public static partial void FreeResourceBundle(string name);

      [JSImport("SplashKitBackendWASM.has_resource_bundle", "main.js")] 
      public static partial bool HasResourceBundle(string name);

      [JSImport("SplashKitBackendWASM.load_resource_bundle", "main.js")] 
      public static partial void LoadResourceBundle(string name, string filename);

      [JSImport("SplashKitBackendWASM.deregister_free_notifier", "main.js")] 
      public static partial void DeregisterFreeNotifier(FreeNotifier handler);

      [JSImport("SplashKitBackendWASM.path_to_resource", "main.js")] 
      public static partial string PathToResource(string filename, ResourceKind kind);

      [JSImport("SplashKitBackendWASM.path_to_resources", "main.js")] 
      public static partial string PathToResources();

      [JSImport("SplashKitBackendWASM.path_to_resources", "main.js")] 
      public static partial string PathToResources(ResourceKind kind);

      [JSImport("SplashKitBackendWASM.register_free_notifier", "main.js")] 
      public static partial void RegisterFreeNotifier(FreeNotifier fn);

      [JSImport("SplashKitBackendWASM.set_resources_path", "main.js")] 
      public static partial void SetResourcesPath(string path);

      [JSImport("SplashKitBackendWASM.call_for_all_sprites", "main.js")] 
      public static partial void CallForAllSprites(SpriteFloatFunction fn, float val);

      [JSImport("SplashKitBackendWASM.call_for_all_sprites", "main.js")] 
      public static partial void CallForAllSprites(SpriteFunction fn);

      [JSImport("SplashKitBackendWASM.call_on_sprite_event", "main.js")] 
      public static partial void CallOnSpriteEvent(SpriteEventHandler handler);

      [JSImport("SplashKitBackendWASM.create_sprite", "main.js")] 
      public static partial Sprite CreateSprite(Bitmap layer);

      [JSImport("SplashKitBackendWASM.create_sprite", "main.js")] 
      public static partial Sprite CreateSprite(Bitmap layer, AnimationScript ani);

      [JSImport("SplashKitBackendWASM.create_sprite", "main.js")] 
      public static partial Sprite CreateSprite(string bitmapName);

      [JSImport("SplashKitBackendWASM.create_sprite", "main.js")] 
      public static partial Sprite CreateSprite(string name, Bitmap layer);

      [JSImport("SplashKitBackendWASM.create_sprite", "main.js")] 
      public static partial Sprite CreateSprite(string name, Bitmap layer, AnimationScript ani);

      [JSImport("SplashKitBackendWASM.create_sprite", "main.js")] 
      public static partial Sprite CreateSprite(string bitmapName, string animationName);

      [JSImport("SplashKitBackendWASM.create_sprite_pack", "main.js")] 
      public static partial void CreateSpritePack(string name);

      [JSImport("SplashKitBackendWASM.current_sprite_pack", "main.js")] 
      public static partial string CurrentSpritePack();

      [JSImport("SplashKitBackendWASM.draw_all_sprites", "main.js")] 
      public static partial void DrawAllSprites();

      [JSImport("SplashKitBackendWASM.draw_sprite", "main.js")] 
      public static partial void DrawSprite(Sprite s, Vector2D offset);

      [JSImport("SplashKitBackendWASM.draw_sprite", "main.js")] 
      public static partial void DrawSprite(Sprite s);

      [JSImport("SplashKitBackendWASM.draw_sprite", "main.js")] 
      public static partial void DrawSprite(Sprite s, double xOffset, double yOffset);

      [JSImport("SplashKitBackendWASM.free_all_sprites", "main.js")] 
      public static partial void FreeAllSprites();

      [JSImport("SplashKitBackendWASM.free_sprite", "main.js")] 
      public static partial void FreeSprite(Sprite s);

      [JSImport("SplashKitBackendWASM.free_sprite_pack", "main.js")] 
      public static partial void FreeSpritePack(string name);

      [JSImport("SplashKitBackendWASM.has_sprite", "main.js")] 
      public static partial bool HasSprite(string name);

      [JSImport("SplashKitBackendWASM.has_sprite_pack", "main.js")] 
      public static partial bool HasSpritePack(string name);

      [JSImport("SplashKitBackendWASM.move_sprite", "main.js")] 
      public static partial void MoveSprite(Sprite s);

      [JSImport("SplashKitBackendWASM.move_sprite", "main.js")] 
      public static partial void MoveSprite(Sprite s, Vector2D distance);

      [JSImport("SplashKitBackendWASM.move_sprite", "main.js")] 
      public static partial void MoveSprite(Sprite s, Vector2D distance, float pct);

      [JSImport("SplashKitBackendWASM.move_sprite", "main.js")] 
      public static partial void MoveSprite(Sprite s, float pct);

      [JSImport("SplashKitBackendWASM.move_sprite_to", "main.js")] 
      public static partial void MoveSpriteTo(Sprite s, double x, double y);

      [JSImport("SplashKitBackendWASM.select_sprite_pack", "main.js")] 
      public static partial void SelectSpritePack(string name);

      [JSImport("SplashKitBackendWASM.sprite_add_layer", "main.js")] 
      public static partial int SpriteAddLayer(Sprite s, Bitmap newLayer, string layerName);

      [JSImport("SplashKitBackendWASM.sprite_add_to_velocity", "main.js")] 
      public static partial void SpriteAddToVelocity(Sprite s, Vector2D value);

      [JSImport("SplashKitBackendWASM.sprite_add_value", "main.js")] 
      public static partial void SpriteAddValue(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_add_value", "main.js")] 
      public static partial void SpriteAddValue(Sprite s, string name, float initVal);

      [JSImport("SplashKitBackendWASM.sprite_anchor_point", "main.js")] 
      public static partial Point2D SpriteAnchorPoint(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_anchor_position", "main.js")] 
      public static partial Point2D SpriteAnchorPosition(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_animation_has_ended", "main.js")] 
      public static partial bool SpriteAnimationHasEnded(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_animation_name", "main.js")] 
      public static partial string SpriteAnimationName(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_at", "main.js")] 
      public static partial bool SpriteAt(Sprite s, Point2D pt);

      [JSImport("SplashKitBackendWASM.sprite_bring_layer_forward", "main.js")] 
      public static partial void SpriteBringLayerForward(Sprite s, int visibleLayer);

      [JSImport("SplashKitBackendWASM.sprite_bring_layer_to_front", "main.js")] 
      public static partial void SpriteBringLayerToFront(Sprite s, int visibleLayer);

      [JSImport("SplashKitBackendWASM.sprite_call_on_event", "main.js")] 
      public static partial void SpriteCallOnEvent(Sprite s, SpriteEventHandler handler);

      [JSImport("SplashKitBackendWASM.sprite_center_point", "main.js")] 
      public static partial Point2D SpriteCenterPoint(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_circle", "main.js")] 
      public static partial Circle SpriteCircle(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_collision_bitmap", "main.js")] 
      public static partial Bitmap SpriteCollisionBitmap(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_collision_circle", "main.js")] 
      public static partial Circle SpriteCollisionCircle(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_collision_kind", "main.js")] 
      public static partial CollisionTestKind SpriteCollisionKind(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_collision_rectangle", "main.js")] 
      public static partial Rectangle SpriteCollisionRectangle(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_current_cell", "main.js")] 
      public static partial int SpriteCurrentCell(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_current_cell_rectangle", "main.js")] 
      public static partial Rectangle SpriteCurrentCellRectangle(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_dx", "main.js")] 
      public static partial double SpriteDx(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_dy", "main.js")] 
      public static partial double SpriteDy(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_has_value", "main.js")] 
      public static partial bool SpriteHasValue(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_heading", "main.js")] 
      public static partial float SpriteHeading(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_height", "main.js")] 
      public static partial int SpriteHeight(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_hide_layer", "main.js")] 
      public static partial void SpriteHideLayer(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_hide_layer", "main.js")] 
      public static partial void SpriteHideLayer(Sprite s, int id);

      [JSImport("SplashKitBackendWASM.sprite_layer", "main.js")] 
      public static partial Bitmap SpriteLayer(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_layer", "main.js")] 
      public static partial Bitmap SpriteLayer(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_circle", "main.js")] 
      public static partial Circle SpriteLayerCircle(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_circle", "main.js")] 
      public static partial Circle SpriteLayerCircle(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_count", "main.js")] 
      public static partial int SpriteLayerCount(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_layer_height", "main.js")] 
      public static partial int SpriteLayerHeight(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_height", "main.js")] 
      public static partial int SpriteLayerHeight(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_index", "main.js")] 
      public static partial int SpriteLayerIndex(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_name", "main.js")] 
      public static partial string SpriteLayerName(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_offset", "main.js")] 
      public static partial Vector2D SpriteLayerOffset(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_offset", "main.js")] 
      public static partial Vector2D SpriteLayerOffset(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_rectangle", "main.js")] 
      public static partial Rectangle SpriteLayerRectangle(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_rectangle", "main.js")] 
      public static partial Rectangle SpriteLayerRectangle(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_width", "main.js")] 
      public static partial int SpriteLayerWidth(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_width", "main.js")] 
      public static partial int SpriteLayerWidth(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_location_matrix", "main.js")] 
      public static partial Matrix2D SpriteLocationMatrix(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_mass", "main.js")] 
      public static partial float SpriteMass(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_move_from_anchor_point", "main.js")] 
      public static partial bool SpriteMoveFromAnchorPoint(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_move_to", "main.js")] 
      public static partial void SpriteMoveTo(Sprite s, Point2D pt, float takingSeconds);

      [JSImport("SplashKitBackendWASM.sprite_name", "main.js")] 
      public static partial string SpriteName(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_named", "main.js")] 
      public static partial Sprite SpriteNamed(string name);

      [JSImport("SplashKitBackendWASM.sprite_offscreen", "main.js")] 
      public static partial bool SpriteOffscreen(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_on_screen_at", "main.js")] 
      public static partial bool SpriteOnScreenAt(Sprite s, Point2D pt);

      [JSImport("SplashKitBackendWASM.sprite_on_screen_at", "main.js")] 
      public static partial bool SpriteOnScreenAt(Sprite s, double x, double y);

      [JSImport("SplashKitBackendWASM.sprite_position", "main.js")] 
      public static partial Point2D SpritePosition(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_replay_animation", "main.js")] 
      public static partial void SpriteReplayAnimation(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_replay_animation", "main.js")] 
      public static partial void SpriteReplayAnimation(Sprite s, bool withSound);

      [JSImport("SplashKitBackendWASM.sprite_rotation", "main.js")] 
      public static partial float SpriteRotation(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_scale", "main.js")] 
      public static partial float SpriteScale(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_screen_rectangle", "main.js")] 
      public static partial Rectangle SpriteScreenRectangle(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_send_layer_backward", "main.js")] 
      public static partial void SpriteSendLayerBackward(Sprite s, int visibleLayer);

      [JSImport("SplashKitBackendWASM.sprite_send_layer_to_back", "main.js")] 
      public static partial void SpriteSendLayerToBack(Sprite s, int visibleLayer);

      [JSImport("SplashKitBackendWASM.sprite_set_anchor_point", "main.js")] 
      public static partial void SpriteSetAnchorPoint(Sprite s, Point2D pt);

      [JSImport("SplashKitBackendWASM.sprite_set_collision_bitmap", "main.js")] 
      public static partial void SpriteSetCollisionBitmap(Sprite s, Bitmap bmp);

      [JSImport("SplashKitBackendWASM.sprite_set_collision_kind", "main.js")] 
      public static partial void SpriteSetCollisionKind(Sprite s, CollisionTestKind value);

      [JSImport("SplashKitBackendWASM.sprite_set_dx", "main.js")] 
      public static partial void SpriteSetDx(Sprite s, double value);

      [JSImport("SplashKitBackendWASM.sprite_set_dy", "main.js")] 
      public static partial void SpriteSetDy(Sprite s, double value);

      [JSImport("SplashKitBackendWASM.sprite_set_heading", "main.js")] 
      public static partial void SpriteSetHeading(Sprite s, float value);

      [JSImport("SplashKitBackendWASM.sprite_set_layer_offset", "main.js")] 
      public static partial void SpriteSetLayerOffset(Sprite s, string name, Vector2D value);

      [JSImport("SplashKitBackendWASM.sprite_set_layer_offset", "main.js")] 
      public static partial void SpriteSetLayerOffset(Sprite s, int idx, Vector2D value);

      [JSImport("SplashKitBackendWASM.sprite_set_mass", "main.js")] 
      public static partial void SpriteSetMass(Sprite s, float value);

      [JSImport("SplashKitBackendWASM.sprite_set_move_from_anchor_point", "main.js")] 
      public static partial void SpriteSetMoveFromAnchorPoint(Sprite s, bool value);

      [JSImport("SplashKitBackendWASM.sprite_set_position", "main.js")] 
      public static partial void SpriteSetPosition(Sprite s, Point2D value);

      [JSImport("SplashKitBackendWASM.sprite_set_rotation", "main.js")] 
      public static partial void SpriteSetRotation(Sprite s, float value);

      [JSImport("SplashKitBackendWASM.sprite_set_scale", "main.js")] 
      public static partial void SpriteSetScale(Sprite s, float value);

      [JSImport("SplashKitBackendWASM.sprite_set_speed", "main.js")] 
      public static partial void SpriteSetSpeed(Sprite s, double value);

      [JSImport("SplashKitBackendWASM.sprite_set_value", "main.js")] 
      public static partial void SpriteSetValue(Sprite s, string name, float val);

      [JSImport("SplashKitBackendWASM.sprite_set_velocity", "main.js")] 
      public static partial void SpriteSetVelocity(Sprite s, Vector2D value);

      [JSImport("SplashKitBackendWASM.sprite_set_x", "main.js")] 
      public static partial void SpriteSetX(Sprite s, double value);

      [JSImport("SplashKitBackendWASM.sprite_set_y", "main.js")] 
      public static partial void SpriteSetY(Sprite s, double value);

      [JSImport("SplashKitBackendWASM.sprite_show_layer", "main.js")] 
      public static partial int SpriteShowLayer(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_show_layer", "main.js")] 
      public static partial int SpriteShowLayer(Sprite s, int id);

      [JSImport("SplashKitBackendWASM.sprite_speed", "main.js")] 
      public static partial double SpriteSpeed(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_start_animation", "main.js")] 
      public static partial void SpriteStartAnimation(Sprite s, string named);

      [JSImport("SplashKitBackendWASM.sprite_start_animation", "main.js")] 
      public static partial void SpriteStartAnimation(Sprite s, string named, bool withSound);

      [JSImport("SplashKitBackendWASM.sprite_start_animation", "main.js")] 
      public static partial void SpriteStartAnimation(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_start_animation", "main.js")] 
      public static partial void SpriteStartAnimation(Sprite s, int idx, bool withSound);

      [JSImport("SplashKitBackendWASM.sprite_stop_calling_on_event", "main.js")] 
      public static partial void SpriteStopCallingOnEvent(Sprite s, SpriteEventHandler handler);

      [JSImport("SplashKitBackendWASM.sprite_toggle_layer_visible", "main.js")] 
      public static partial void SpriteToggleLayerVisible(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_toggle_layer_visible", "main.js")] 
      public static partial void SpriteToggleLayerVisible(Sprite s, int id);

      [JSImport("SplashKitBackendWASM.sprite_value", "main.js")] 
      public static partial float SpriteValue(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_value_count", "main.js")] 
      public static partial int SpriteValueCount(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_velocity", "main.js")] 
      public static partial Vector2D SpriteVelocity(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_visible_index_of_layer", "main.js")] 
      public static partial int SpriteVisibleIndexOfLayer(Sprite s, string name);

      [JSImport("SplashKitBackendWASM.sprite_visible_index_of_layer", "main.js")] 
      public static partial int SpriteVisibleIndexOfLayer(Sprite s, int id);

      [JSImport("SplashKitBackendWASM.sprite_visible_layer", "main.js")] 
      public static partial int SpriteVisibleLayer(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_visible_layer_count", "main.js")] 
      public static partial int SpriteVisibleLayerCount(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_visible_layer_id", "main.js")] 
      public static partial int SpriteVisibleLayerId(Sprite s, int idx);

      [JSImport("SplashKitBackendWASM.sprite_width", "main.js")] 
      public static partial int SpriteWidth(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_x", "main.js")] 
      public static partial double SpriteX(Sprite s);

      [JSImport("SplashKitBackendWASM.sprite_y", "main.js")] 
      public static partial double SpriteY(Sprite s);

      [JSImport("SplashKitBackendWASM.stop_calling_on_sprite_event", "main.js")] 
      public static partial void StopCallingOnSpriteEvent(SpriteEventHandler handler);

      [JSImport("SplashKitBackendWASM.update_all_sprites", "main.js")] 
      public static partial void UpdateAllSprites();

      [JSImport("SplashKitBackendWASM.update_all_sprites", "main.js")] 
      public static partial void UpdateAllSprites(float pct);

      [JSImport("SplashKitBackendWASM.update_sprite", "main.js")] 
      public static partial void UpdateSprite(Sprite s);

      [JSImport("SplashKitBackendWASM.update_sprite", "main.js")] 
      public static partial void UpdateSprite(Sprite s, bool withSound);

      [JSImport("SplashKitBackendWASM.update_sprite", "main.js")] 
      public static partial void UpdateSprite(Sprite s, float pct);

      [JSImport("SplashKitBackendWASM.update_sprite", "main.js")] 
      public static partial void UpdateSprite(Sprite s, float pct, bool withSound);

      [JSImport("SplashKitBackendWASM.update_sprite_animation", "main.js")] 
      public static partial void UpdateSpriteAnimation(Sprite s);

      [JSImport("SplashKitBackendWASM.update_sprite_animation", "main.js")] 
      public static partial void UpdateSpriteAnimation(Sprite s, bool withSound);

      [JSImport("SplashKitBackendWASM.update_sprite_animation", "main.js")] 
      public static partial void UpdateSpriteAnimation(Sprite s, float pct);

      [JSImport("SplashKitBackendWASM.update_sprite_animation", "main.js")] 
      public static partial void UpdateSpriteAnimation(Sprite s, float pct, bool withSound);

      [JSImport("SplashKitBackendWASM.vector_from_center_sprite_to_point", "main.js")] 
      public static partial Vector2D VectorFromCenterSpriteToPoint(Sprite s, Point2D pt);

      [JSImport("SplashKitBackendWASM.vector_from_to", "main.js")] 
      public static partial Vector2D VectorFromTo(Sprite s1, Sprite s2);

      [JSImport("SplashKitBackendWASM.read_char", "main.js")] 
      public static partial char ReadChar();

      [JSImport("SplashKitBackendWASM.read_line", "main.js")] 
      public static partial string ReadLine();

      [JSImport("SplashKitBackendWASM.terminal_has_input", "main.js")] 
      public static partial bool TerminalHasInput();

      [JSImport("SplashKitBackendWASM.write", "main.js")] 
      public static partial void Write(char data);

      [JSImport("SplashKitBackendWASM.write", "main.js")] 
      public static partial void Write(double data);

      [JSImport("SplashKitBackendWASM.write", "main.js")] 
      public static partial void Write(int data);

      [JSImport("SplashKitBackendWASM.write", "main.js")] 
      public static partial void Write(string text);

      [JSImport("SplashKitBackendWASM.write_line", "main.js")] 
      public static partial void WriteLine(char data);

      [JSImport("SplashKitBackendWASM.write_line", "main.js")] 
      public static partial void WriteLine();

      [JSImport("SplashKitBackendWASM.write_line", "main.js")] 
      public static partial void WriteLine(double data);

      [JSImport("SplashKitBackendWASM.write_line", "main.js")] 
      public static partial void WriteLine(int data);

      [JSImport("SplashKitBackendWASM.write_line", "main.js")] 
      public static partial void WriteLine(string line);

      [JSImport("SplashKitBackendWASM.create_timer", "main.js")] 
      public static partial Timer CreateTimer(string name);

      [JSImport("SplashKitBackendWASM.free_all_timers", "main.js")] 
      public static partial void FreeAllTimers();

      [JSImport("SplashKitBackendWASM.free_timer", "main.js")] 
      public static partial void FreeTimer(Timer toFree);

      [JSImport("SplashKitBackendWASM.has_timer", "main.js")] 
      public static partial bool HasTimer(string name);

      [JSImport("SplashKitBackendWASM.pause_timer", "main.js")] 
      public static partial void PauseTimer(string name);

      [JSImport("SplashKitBackendWASM.pause_timer", "main.js")] 
      public static partial void PauseTimer(Timer toPause);

      [JSImport("SplashKitBackendWASM.reset_timer", "main.js")] 
      public static partial void ResetTimer(string name);

      [JSImport("SplashKitBackendWASM.reset_timer", "main.js")] 
      public static partial void ResetTimer(Timer tmr);

      [JSImport("SplashKitBackendWASM.resume_timer", "main.js")] 
      public static partial void ResumeTimer(string name);

      [JSImport("SplashKitBackendWASM.resume_timer", "main.js")] 
      public static partial void ResumeTimer(Timer toResume);

      [JSImport("SplashKitBackendWASM.start_timer", "main.js")] 
      public static partial void StartTimer(string name);

      [JSImport("SplashKitBackendWASM.start_timer", "main.js")] 
      public static partial void StartTimer(Timer toStart);

      [JSImport("SplashKitBackendWASM.stop_timer", "main.js")] 
      public static partial void StopTimer(string name);

      [JSImport("SplashKitBackendWASM.stop_timer", "main.js")] 
      public static partial void StopTimer(Timer toStop);

      [JSImport("SplashKitBackendWASM.timer_named", "main.js")] 
      public static partial Timer TimerNamed(string name);

      [JSImport("SplashKitBackendWASM.timer_paused", "main.js")] 
      public static partial bool TimerPaused(string name);

      [JSImport("SplashKitBackendWASM.timer_paused", "main.js")] 
      public static partial bool TimerPaused(Timer toGet);

      [JSImport("SplashKitBackendWASM.timer_started", "main.js")] 
      public static partial bool TimerStarted(string name);

      [JSImport("SplashKitBackendWASM.timer_started", "main.js")] 
      public static partial bool TimerStarted(Timer toGet);

      [JSImport("SplashKitBackendWASM.timer_ticks", "main.js")] 
      public static partial uint TimerTicks(string name);

      [JSImport("SplashKitBackendWASM.timer_ticks", "main.js")] 
      public static partial uint TimerTicks(Timer toGet);

      [JSImport("SplashKitBackendWASM.base64_decode", "main.js")] 
      public static partial string Base64Decode(string input);

      [JSImport("SplashKitBackendWASM.base64_encode", "main.js")] 
      public static partial string Base64Encode(string input);

      [JSImport("SplashKitBackendWASM.bin_to_dec", "main.js")] 
      public static partial uint BinToDec(string bin);

      [JSImport("SplashKitBackendWASM.bin_to_hex", "main.js")] 
      public static partial string BinToHex(string binStr);

      [JSImport("SplashKitBackendWASM.bin_to_oct", "main.js")] 
      public static partial string BinToOct(string binStr);

      [JSImport("SplashKitBackendWASM.contains", "main.js")] 
      public static partial bool Contains(string text, string subtext);

      [JSImport("SplashKitBackendWASM.convert_to_double", "main.js")] 
      public static partial double ConvertToDouble(string text);

      [JSImport("SplashKitBackendWASM.convert_to_integer", "main.js")] 
      public static partial int ConvertToInteger(string text);

      [JSImport("SplashKitBackendWASM.dec_to_bin", "main.js")] 
      public static partial string DecToBin(uint dec);

      [JSImport("SplashKitBackendWASM.dec_to_oct", "main.js")] 
      public static partial string DecToOct(uint decimalValue);

      [JSImport("SplashKitBackendWASM.greatest_common_divisor", "main.js")] 
      public static partial int GreatestCommonDivisor(int number1, int number2);

      [JSImport("SplashKitBackendWASM.hex_to_bin", "main.js")] 
      public static partial string HexToBin(string hexStr);

      [JSImport("SplashKitBackendWASM.hex_to_dec", "main.js")] 
      public static partial uint HexToDec(string hexString);

      [JSImport("SplashKitBackendWASM.hex_to_oct", "main.js")] 
      public static partial string HexToOct(string hexStr);

      [JSImport("SplashKitBackendWASM.index_of", "main.js")] 
      public static partial int IndexOf(string text, string subtext);

      [JSImport("SplashKitBackendWASM.is_binary", "main.js")] 
      public static partial bool IsBinary(string binStr);

      [JSImport("SplashKitBackendWASM.is_double", "main.js")] 
      public static partial bool IsDouble(string text);

      [JSImport("SplashKitBackendWASM.is_hex", "main.js")] 
      public static partial bool IsHex(string hexStr);

      [JSImport("SplashKitBackendWASM.is_integer", "main.js")] 
      public static partial bool IsInteger(string text);

      [JSImport("SplashKitBackendWASM.is_number", "main.js")] 
      public static partial bool IsNumber(string text);

      [JSImport("SplashKitBackendWASM.is_octal", "main.js")] 
      public static partial bool IsOctal(string octalStr);

      [JSImport("SplashKitBackendWASM.is_prime_number", "main.js")] 
      public static partial bool IsPrimeNumber(int number);

      [JSImport("SplashKitBackendWASM.least_common_multiple", "main.js")] 
      public static partial int LeastCommonMultiple(int number1, int number2);

      [JSImport("SplashKitBackendWASM.length_of", "main.js")] 
      public static partial int LengthOf(string text);

      [JSImport("SplashKitBackendWASM.oct_to_bin", "main.js")] 
      public static partial string OctToBin(string octalStr);

      [JSImport("SplashKitBackendWASM.oct_to_dec", "main.js")] 
      public static partial uint OctToDec(string octalString);

      [JSImport("SplashKitBackendWASM.oct_to_hex", "main.js")] 
      public static partial string OctToHex(string octStr);

      [JSImport("SplashKitBackendWASM.replace_all", "main.js")] 
      public static partial string ReplaceAll(string text, string substr, string newText);

      [JSImport("SplashKitBackendWASM.split", "main.js")] 
      public static partial List<string> Split(string text, char delimiter);

      [JSImport("SplashKitBackendWASM.square_root", "main.js")] 
      public static partial double SquareRoot(int number);

      [JSImport("SplashKitBackendWASM.to_lowercase", "main.js")] 
      public static partial string ToLowercase(string text);

      [JSImport("SplashKitBackendWASM.to_uppercase", "main.js")] 
      public static partial string ToUppercase(string text);

      [JSImport("SplashKitBackendWASM.trim", "main.js")] 
      public static partial string Trim(string text);

      [JSImport("SplashKitBackendWASM.rnd", "main.js")] 
      public static partial int Rnd(int min, int max);

      [JSImport("SplashKitBackendWASM.rnd", "main.js")] 
      public static partial float Rnd();

      [JSImport("SplashKitBackendWASM.rnd", "main.js")] 
      public static partial int Rnd(int ubound);

      [JSImport("SplashKitBackendWASM.current_ticks", "main.js")] 
      public static partial uint CurrentTicks();

      [JSImport("SplashKitBackendWASM.delay", "main.js")] 
      public static partial void Delay(int milliseconds);

      [JSImport("SplashKitBackendWASM.display_dialog", "main.js")] 
      public static partial void DisplayDialog(string title, string msg, Font outputFont, int fontSize);

      [JSImport("SplashKitBackendWASM.file_as_string", "main.js")] 
      public static partial string FileAsString(string filename, ResourceKind kind);

      [JSImport("SplashKitBackendWASM.clear_window", "main.js")] 
      public static partial void ClearWindow(Window wind, Color clr);

      [JSImport("SplashKitBackendWASM.close_all_windows", "main.js")] 
      public static partial void CloseAllWindows();

      [JSImport("SplashKitBackendWASM.close_current_window", "main.js")] 
      public static partial void CloseCurrentWindow();

      [JSImport("SplashKitBackendWASM.close_window", "main.js")] 
      public static partial void CloseWindow(string name);

      [JSImport("SplashKitBackendWASM.close_window", "main.js")] 
      public static partial void CloseWindow(Window wind);

      [JSImport("SplashKitBackendWASM.current_window", "main.js")] 
      public static partial Window CurrentWindow();

      [JSImport("SplashKitBackendWASM.current_window_has_border", "main.js")] 
      public static partial bool CurrentWindowHasBorder();

      [JSImport("SplashKitBackendWASM.current_window_height", "main.js")] 
      public static partial int CurrentWindowHeight();

      [JSImport("SplashKitBackendWASM.current_window_is_fullscreen", "main.js")] 
      public static partial bool CurrentWindowIsFullscreen();

      [JSImport("SplashKitBackendWASM.current_window_position", "main.js")] 
      public static partial Point2D CurrentWindowPosition();

      [JSImport("SplashKitBackendWASM.current_window_toggle_border", "main.js")] 
      public static partial void CurrentWindowToggleBorder();

      [JSImport("SplashKitBackendWASM.current_window_toggle_fullscreen", "main.js")] 
      public static partial void CurrentWindowToggleFullscreen();

      [JSImport("SplashKitBackendWASM.current_window_width", "main.js")] 
      public static partial int CurrentWindowWidth();

      [JSImport("SplashKitBackendWASM.current_window_x", "main.js")] 
      public static partial int CurrentWindowX();

      [JSImport("SplashKitBackendWASM.current_window_y", "main.js")] 
      public static partial int CurrentWindowY();

      [JSImport("SplashKitBackendWASM.has_window", "main.js")] 
      public static partial bool HasWindow(string caption);

      [JSImport("SplashKitBackendWASM.is_current_window", "main.js")] 
      public static partial bool IsCurrentWindow(Window wind);

      [JSImport("SplashKitBackendWASM.move_current_window_to", "main.js")] 
      public static partial void MoveCurrentWindowTo(int x, int y);

      [JSImport("SplashKitBackendWASM.move_window_to", "main.js")] 
      public static partial void MoveWindowTo(string name, int x, int y);

      [JSImport("SplashKitBackendWASM.move_window_to", "main.js")] 
      public static partial void MoveWindowTo(Window wind, int x, int y);

      [JSImport("SplashKitBackendWASM.open_window", "main.js")] 
      public static partial Window OpenWindow(string caption, int width, int height);

      [JSImport("SplashKitBackendWASM.refresh_window", "main.js")] 
      public static partial void RefreshWindow(Window wind);

      [JSImport("SplashKitBackendWASM.refresh_window", "main.js")] 
      public static partial void RefreshWindow(Window wind, uint targetFps);

      [JSImport("SplashKitBackendWASM.resize_current_window", "main.js")] 
      public static partial void ResizeCurrentWindow(int width, int height);

      [JSImport("SplashKitBackendWASM.resize_window", "main.js")] 
      public static partial void ResizeWindow(Window wnd, int width, int height);

      [JSImport("SplashKitBackendWASM.set_current_window", "main.js")] 
      public static partial void SetCurrentWindow(string name);

      [JSImport("SplashKitBackendWASM.set_current_window", "main.js")] 
      public static partial void SetCurrentWindow(Window wind);

      [JSImport("SplashKitBackendWASM.window_caption", "main.js")] 
      public static partial string WindowCaption(Window wind);

      [JSImport("SplashKitBackendWASM.window_close_requested", "main.js")] 
      public static partial bool WindowCloseRequested(string name);

      [JSImport("SplashKitBackendWASM.window_close_requested", "main.js")] 
      public static partial bool WindowCloseRequested(Window wind);

      [JSImport("SplashKitBackendWASM.window_has_border", "main.js")] 
      public static partial bool WindowHasBorder(string name);

      [JSImport("SplashKitBackendWASM.window_has_border", "main.js")] 
      public static partial bool WindowHasBorder(Window wnd);

      [JSImport("SplashKitBackendWASM.window_has_focus", "main.js")] 
      public static partial bool WindowHasFocus(Window wind);

      [JSImport("SplashKitBackendWASM.window_height", "main.js")] 
      public static partial int WindowHeight(string name);

      [JSImport("SplashKitBackendWASM.window_height", "main.js")] 
      public static partial int WindowHeight(Window wind);

      [JSImport("SplashKitBackendWASM.window_is_fullscreen", "main.js")] 
      public static partial bool WindowIsFullscreen(string name);

      [JSImport("SplashKitBackendWASM.window_is_fullscreen", "main.js")] 
      public static partial bool WindowIsFullscreen(Window wnd);

      [JSImport("SplashKitBackendWASM.window_named", "main.js")] 
      public static partial Window WindowNamed(string caption);

      [JSImport("SplashKitBackendWASM.window_position", "main.js")] 
      public static partial Point2D WindowPosition(string name);

      [JSImport("SplashKitBackendWASM.window_position", "main.js")] 
      public static partial Point2D WindowPosition(Window wnd);

      [JSImport("SplashKitBackendWASM.window_set_icon", "main.js")] 
      public static partial void WindowSetIcon(Window wind, Bitmap bmp);

      [JSImport("SplashKitBackendWASM.window_toggle_border", "main.js")] 
      public static partial void WindowToggleBorder(string name);

      [JSImport("SplashKitBackendWASM.window_toggle_border", "main.js")] 
      public static partial void WindowToggleBorder(Window wnd);

      [JSImport("SplashKitBackendWASM.window_toggle_fullscreen", "main.js")] 
      public static partial void WindowToggleFullscreen(string name);

      [JSImport("SplashKitBackendWASM.window_toggle_fullscreen", "main.js")] 
      public static partial void WindowToggleFullscreen(Window wnd);

      [JSImport("SplashKitBackendWASM.window_width", "main.js")] 
      public static partial int WindowWidth(string name);

      [JSImport("SplashKitBackendWASM.window_width", "main.js")] 
      public static partial int WindowWidth(Window wind);

      [JSImport("SplashKitBackendWASM.window_with_focus", "main.js")] 
      public static partial Window WindowWithFocus();

      [JSImport("SplashKitBackendWASM.window_x", "main.js")] 
      public static partial int WindowX(string name);

      [JSImport("SplashKitBackendWASM.window_x", "main.js")] 
      public static partial int WindowX(Window wnd);

      [JSImport("SplashKitBackendWASM.window_y", "main.js")] 
      public static partial int WindowY(string name);

      [JSImport("SplashKitBackendWASM.window_y", "main.js")] 
      public static partial int WindowY(Window wnd);

     } 

   public partial class Animation
   {
      [JSImport("SplashKitBackendWASM.animation_current_cell", "main.js")] 
      public partial int CurrentCell;

      [JSImport("SplashKitBackendWASM.animation_current_vector", "main.js")] 
      public partial Vector2D CurrentVector;

      [JSImport("SplashKitBackendWASM.animation_ended", "main.js")] 
      public partial bool Ended;

      [JSImport("SplashKitBackendWASM.animation_entered_frame", "main.js")] 
      public partial bool EnteredFrame;

      [JSImport("SplashKitBackendWASM.animation_frame_time", "main.js")] 
      public partial float FrameTime;

      [JSImport("SplashKitBackendWASM.animation_name", "main.js")] 
      public partial string Name;

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(AnimationScript script, string name);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(AnimationScript script, string name, bool withSound);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(AnimationScript script, int idx);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(AnimationScript script, int idx, bool withSound);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(string scriptName, string name);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(string scriptName, string name, bool withSound);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(int idx);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(int idx, bool withSound);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(string name);

      [JSImport("SplashKitBackendWASM.assign_animation", "main.js")] 
      public partial void Assign(string name, bool withSound);

      [JSImport("SplashKitBackendWASM.free_all_animation_scripts", "main.js")] 
      public static partial void FreeAll();

      [JSImport("SplashKitBackendWASM.free_animation", "main.js")] 
      public partial void Free();

      [JSImport("SplashKitBackendWASM.restart_animation", "main.js")] 
      public partial void Restart();

      [JSImport("SplashKitBackendWASM.restart_animation", "main.js")] 
      public partial void Restart(bool withSound);

      [JSImport("SplashKitBackendWASM.update_animation", "main.js")] 
      public partial void Update();

      [JSImport("SplashKitBackendWASM.update_animation", "main.js")] 
      public partial void Update(float pct);

     } 

   public partial class Audio
   {
      [JSImport("SplashKitBackendWASM.audio_ready", "main.js")] 
      public static partial bool IsReady;

      [JSImport("SplashKitBackendWASM.fade_music_out", "main.js")] 
      public static partial void FadeOut(int ms);

      [JSImport("SplashKitBackendWASM.free_all_music", "main.js")] 
      public static partial void FreeAllMusic();

      [JSImport("SplashKitBackendWASM.music_playing", "main.js")] 
      public static partial bool Playing;

      [JSImport("SplashKitBackendWASM.music_volume", "main.js")] 
      public static partial double Volume;

      [JSImport("SplashKitBackendWASM.pause_music", "main.js")] 
      public static partial void Pause();

      [JSImport("SplashKitBackendWASM.resume_music", "main.js")] 
      public static partial void Resume();

      [JSImport("SplashKitBackendWASM.set_music_volume", "main.js")] 
      public static partial void Volume;

      [JSImport("SplashKitBackendWASM.stop_music", "main.js")] 
      public static partial void Stop();

     } 

   public partial class Music
   {
      [JSImport("SplashKitBackendWASM.fade_music_in", "main.js")] 
      public partial void FadeIn(int ms);

      [JSImport("SplashKitBackendWASM.fade_music_in", "main.js")] 
      public partial void FadeIn(int times, int ms);

      [JSImport("SplashKitBackendWASM.free_music", "main.js")] 
      public partial void Free();

      [JSImport("SplashKitBackendWASM.music_filename", "main.js")] 
      public partial string Filename;

      [JSImport("SplashKitBackendWASM.music_name", "main.js")] 
      public partial string Name;

      [JSImport("SplashKitBackendWASM.play_music", "main.js")] 
      public partial void Play();

      [JSImport("SplashKitBackendWASM.play_music", "main.js")] 
      public partial void Play(int times);

      [JSImport("SplashKitBackendWASM.play_music", "main.js")] 
      public partial void Play(int times, double volume);

     } 

   public partial class SoundEffect
   {
      [JSImport("SplashKitBackendWASM.fade_sound_effect_out", "main.js")] 
      public partial void FadeOut(int ms);

      [JSImport("SplashKitBackendWASM.free_sound_effect", "main.js")] 
      public partial void Close();

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public partial void Play();

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public partial void Play(double volume);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public partial void Play(int times);

      [JSImport("SplashKitBackendWASM.play_sound_effect", "main.js")] 
      public partial void Play(int times, double volume);

      [JSImport("SplashKitBackendWASM.sound_effect_filename", "main.js")] 
      public partial string Filename;

      [JSImport("SplashKitBackendWASM.sound_effect_name", "main.js")] 
      public partial string Name;

      [JSImport("SplashKitBackendWASM.sound_effect_playing", "main.js")] 
      public partial bool IsPlaying;

      [JSImport("SplashKitBackendWASM.stop_sound_effect", "main.js")] 
      public partial void Stop();

     } 

   public partial class Camera
   {
      [JSImport("SplashKitBackendWASM.camera_position", "main.js")] 
      public static partial Point2D Position;

      [JSImport("SplashKitBackendWASM.camera_x", "main.js")] 
      public static partial double X;

      [JSImport("SplashKitBackendWASM.camera_y", "main.js")] 
      public static partial double Y;

      [JSImport("SplashKitBackendWASM.center_camera_on", "main.js")] 
      public static partial void CenterOn(Sprite s, Vector2D offset);

      [JSImport("SplashKitBackendWASM.center_camera_on", "main.js")] 
      public static partial void CenterOn(Sprite s, double offsetX, double offsetY);

      [JSImport("SplashKitBackendWASM.move_camera_by", "main.js")] 
      public static partial void MoveBy(Vector2D offset);

      [JSImport("SplashKitBackendWASM.move_camera_by", "main.js")] 
      public static partial void MoveBy(double dx, double dy);

      [JSImport("SplashKitBackendWASM.move_camera_to", "main.js")] 
      public static partial void MoveTo(Point2D pt);

      [JSImport("SplashKitBackendWASM.move_camera_to", "main.js")] 
      public static partial void MoveTo(double x, double y);

      [JSImport("SplashKitBackendWASM.point_in_window", "main.js")] 
      public static partial bool PointInWindow(Window wind, Point2D pt);

      [JSImport("SplashKitBackendWASM.point_on_screen", "main.js")] 
      public static partial bool PointOnScreen(Point2D pt);

      [JSImport("SplashKitBackendWASM.rect_in_window", "main.js")] 
      public static partial bool RectInWindow(Window wind, Rectangle rect);

      [JSImport("SplashKitBackendWASM.rect_on_screen", "main.js")] 
      public static partial bool RectOnScreen(Rectangle rect);

      [JSImport("SplashKitBackendWASM.screen_center", "main.js")] 
      public static partial Point2D ScreenCenter;

      [JSImport("SplashKitBackendWASM.screen_rectangle", "main.js")] 
      public static partial Rectangle ScreenRectangle;

      [JSImport("SplashKitBackendWASM.set_camera_position", "main.js")] 
      public static partial void Position;

      [JSImport("SplashKitBackendWASM.set_camera_x", "main.js")] 
      public static partial void X;

      [JSImport("SplashKitBackendWASM.set_camera_y", "main.js")] 
      public static partial void Y;

      [JSImport("SplashKitBackendWASM.to_screen", "main.js")] 
      public static partial Point2D ToScreen(Point2D pt);

      [JSImport("SplashKitBackendWASM.to_screen", "main.js")] 
      public static partial Rectangle ToScreen(Rectangle rect);

      [JSImport("SplashKitBackendWASM.to_screen_x", "main.js")] 
      public static partial double ToScreenX(double worldX);

      [JSImport("SplashKitBackendWASM.to_screen_y", "main.js")] 
      public static partial double ToScreenY(double worldY);

      [JSImport("SplashKitBackendWASM.to_world", "main.js")] 
      public static partial Point2D ToWorld(Point2D pt);

      [JSImport("SplashKitBackendWASM.to_world_x", "main.js")] 
      public static partial double ToWorldX(double screenX);

      [JSImport("SplashKitBackendWASM.to_world_y", "main.js")] 
      public static partial double ToWorldY(double screenY);

      [JSImport("SplashKitBackendWASM.vector_world_to_screen", "main.js")] 
      public static partial Vector2D VectorWorldToScreen;

     } 

   public partial class Window
   {
      [JSImport("SplashKitBackendWASM.window_area", "main.js")] 
      public partial Rectangle Area;

      [JSImport("SplashKitBackendWASM.random_window_point", "main.js")] 
      public partial Point2D RandomPoint();

      [JSImport("SplashKitBackendWASM.draw_circle_on_window", "main.js")] 
      public partial void DrawCircle(Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.draw_circle_on_window", "main.js")] 
      public partial void DrawCircle(Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_circle_on_window", "main.js")] 
      public partial void FillCircle(Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.fill_circle_on_window", "main.js")] 
      public partial void FillCircle(Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.current_clip", "main.js")] 
      public partial Rectangle CurrentClip();

      [JSImport("SplashKitBackendWASM.pop_clip", "main.js")] 
      public partial void PopClip();

      [JSImport("SplashKitBackendWASM.push_clip", "main.js")] 
      public partial void PushClip(Rectangle r);

      [JSImport("SplashKitBackendWASM.reset_clip", "main.js")] 
      public partial void ResetClip();

      [JSImport("SplashKitBackendWASM.set_clip", "main.js")] 
      public partial void SetClip(Rectangle r);

      [JSImport("SplashKitBackendWASM.option_draw_to", "main.js")] 
      public partial DrawingOptions OptionDrawTo();

      [JSImport("SplashKitBackendWASM.option_draw_to", "main.js")] 
      public partial DrawingOptions OptionDrawTo(DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_window", "main.js")] 
      public partial void DrawEllipse(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_window", "main.js")] 
      public partial void DrawEllipse(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_window", "main.js")] 
      public partial void DrawEllipse(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_window", "main.js")] 
      public partial void DrawEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_window", "main.js")] 
      public partial void FillEllipse(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_window", "main.js")] 
      public partial void FillEllipse(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_window", "main.js")] 
      public partial void FillEllipse(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_window", "main.js")] 
      public partial void FillEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.take_screenshot", "main.js")] 
      public partial void TakeScreenshot(string basename);

      [JSImport("SplashKitBackendWASM.draw_bitmap_on_window", "main.js")] 
      public partial void DrawBitmap(Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_bitmap_on_window", "main.js")] 
      public partial void DrawBitmap(Bitmap bmp, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public partial void DrawLine(Color clr, Line l);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public partial void DrawLine(Color clr, Line l, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public partial void DrawLine(Color clr, Point2D fromPt, Point2D toPt);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public partial void DrawLine(Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public partial void DrawLine(Color clr, double x1, double y1, double x2, double y2);

      [JSImport("SplashKitBackendWASM.draw_line_on_window", "main.js")] 
      public partial void DrawLine(Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_window", "main.js")] 
      public partial void DrawPixel(Color clr, Point2D pt);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_window", "main.js")] 
      public partial void DrawPixel(Color clr, Point2D pt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_window", "main.js")] 
      public partial void DrawPixel(Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_window", "main.js")] 
      public partial void DrawPixel(Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_quad_on_window", "main.js")] 
      public partial void DrawQuad(Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.draw_quad_on_window", "main.js")] 
      public partial void DrawQuad(Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_window", "main.js")] 
      public partial void DrawRectangle(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_window", "main.js")] 
      public partial void DrawRectangle(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_window", "main.js")] 
      public partial void DrawRectangle(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_window", "main.js")] 
      public partial void DrawRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_quad_on_window", "main.js")] 
      public partial void FillQuad(Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.fill_quad_on_window", "main.js")] 
      public partial void FillQuad(Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_window", "main.js")] 
      public partial void FillRectangle(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_window", "main.js")] 
      public partial void FillRectangle(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_window", "main.js")] 
      public partial void FillRectangle(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_window", "main.js")] 
      public partial void FillRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public partial void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public partial void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public partial void DrawText(string text, Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public partial void DrawText(string text, Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public partial void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_window", "main.js")] 
      public partial void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_window", "main.js")] 
      public partial void DrawTriangle(Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_window", "main.js")] 
      public partial void DrawTriangle(Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_window", "main.js")] 
      public partial void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_window", "main.js")] 
      public partial void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_window", "main.js")] 
      public partial void FillTriangle(Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_window", "main.js")] 
      public partial void FillTriangle(Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_window", "main.js")] 
      public partial void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_window", "main.js")] 
      public partial void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.end_reading_text", "main.js")] 
      public partial void EndReadingText();

      [JSImport("SplashKitBackendWASM.reading_text", "main.js")] 
      public partial bool ReadingText();

      [JSImport("SplashKitBackendWASM.start_reading_text", "main.js")] 
      public partial void StartReadingText(Rectangle rect);

      [JSImport("SplashKitBackendWASM.start_reading_text", "main.js")] 
      public partial void StartReadingText(Rectangle rect, string initialText);

      [JSImport("SplashKitBackendWASM.text_entry_cancelled", "main.js")] 
      public partial bool TextEntryCancelled();

      [JSImport("SplashKitBackendWASM.text_input", "main.js")] 
      public partial string TextInput();

      [JSImport("SplashKitBackendWASM.clear_window", "main.js")] 
      public partial void Clear(Color clr);

      [JSImport("SplashKitBackendWASM.close_window", "main.js")] 
      public partial void Close();

      [JSImport("SplashKitBackendWASM.is_current_window", "main.js")] 
      public partial bool IsCurrentWindow;

      [JSImport("SplashKitBackendWASM.move_window_to", "main.js")] 
      public partial void MoveTo(int x, int y);

      [JSImport("SplashKitBackendWASM.refresh_window", "main.js")] 
      public partial void Refresh();

      [JSImport("SplashKitBackendWASM.refresh_window", "main.js")] 
      public partial void Refresh(uint targetFps);

      [JSImport("SplashKitBackendWASM.resize_window", "main.js")] 
      public partial void Resize(int width, int height);

      [JSImport("SplashKitBackendWASM.set_current_window", "main.js")] 
      public partial void MakeCurrent();

      [JSImport("SplashKitBackendWASM.window_caption", "main.js")] 
      public partial string Caption;

      [JSImport("SplashKitBackendWASM.window_close_requested", "main.js")] 
      public partial bool CloseRequested;

      [JSImport("SplashKitBackendWASM.window_has_border", "main.js")] 
      public partial bool HasBorder;

      [JSImport("SplashKitBackendWASM.window_has_focus", "main.js")] 
      public partial bool HasFocus;

      [JSImport("SplashKitBackendWASM.window_height", "main.js")] 
      public partial int Height;

      [JSImport("SplashKitBackendWASM.window_is_fullscreen", "main.js")] 
      public partial bool IsFullscreen;

      [JSImport("SplashKitBackendWASM.window_position", "main.js")] 
      public partial Point2D Position;

      [JSImport("SplashKitBackendWASM.window_set_icon", "main.js")] 
      public partial void Icon;

      [JSImport("SplashKitBackendWASM.window_toggle_border", "main.js")] 
      public partial void ToggleBorder();

      [JSImport("SplashKitBackendWASM.window_toggle_fullscreen", "main.js")] 
      public partial void ToggleFullscreen();

      [JSImport("SplashKitBackendWASM.window_width", "main.js")] 
      public partial int Width;

      [JSImport("SplashKitBackendWASM.window_x", "main.js")] 
      public partial int X;

      [JSImport("SplashKitBackendWASM.window_y", "main.js")] 
      public partial int Y;

     } 

   public partial class Color
   {
      [JSImport("SplashKitBackendWASM.color_alice_blue", "main.js")] 
      public static partial Color AliceBlue;

      [JSImport("SplashKitBackendWASM.color_antique_white", "main.js")] 
      public static partial Color AntiqueWhite;

      [JSImport("SplashKitBackendWASM.color_aqua", "main.js")] 
      public static partial Color Aqua;

      [JSImport("SplashKitBackendWASM.color_aquamarine", "main.js")] 
      public static partial Color Aquamarine;

      [JSImport("SplashKitBackendWASM.color_azure", "main.js")] 
      public static partial Color Azure;

      [JSImport("SplashKitBackendWASM.color_beige", "main.js")] 
      public static partial Color Beige;

      [JSImport("SplashKitBackendWASM.color_bisque", "main.js")] 
      public static partial Color Bisque;

      [JSImport("SplashKitBackendWASM.color_black", "main.js")] 
      public static partial Color Black;

      [JSImport("SplashKitBackendWASM.color_blanched_almond", "main.js")] 
      public static partial Color BlanchedAlmond;

      [JSImport("SplashKitBackendWASM.color_blue", "main.js")] 
      public static partial Color Blue;

      [JSImport("SplashKitBackendWASM.color_blue_violet", "main.js")] 
      public static partial Color BlueViolet;

      [JSImport("SplashKitBackendWASM.color_bright_green", "main.js")] 
      public static partial Color BrightGreen;

      [JSImport("SplashKitBackendWASM.color_brown", "main.js")] 
      public static partial Color Brown;

      [JSImport("SplashKitBackendWASM.color_burly_wood", "main.js")] 
      public static partial Color BurlyWood;

      [JSImport("SplashKitBackendWASM.color_cadet_blue", "main.js")] 
      public static partial Color CadetBlue;

      [JSImport("SplashKitBackendWASM.color_chartreuse", "main.js")] 
      public static partial Color Chartreuse;

      [JSImport("SplashKitBackendWASM.color_chocolate", "main.js")] 
      public static partial Color Chocolate;

      [JSImport("SplashKitBackendWASM.color_coral", "main.js")] 
      public static partial Color Coral;

      [JSImport("SplashKitBackendWASM.color_cornflower_blue", "main.js")] 
      public static partial Color CornflowerBlue;

      [JSImport("SplashKitBackendWASM.color_cornsilk", "main.js")] 
      public static partial Color Cornsilk;

      [JSImport("SplashKitBackendWASM.color_crimson", "main.js")] 
      public static partial Color Crimson;

      [JSImport("SplashKitBackendWASM.color_cyan", "main.js")] 
      public static partial Color Cyan;

      [JSImport("SplashKitBackendWASM.color_dark_blue", "main.js")] 
      public static partial Color DarkBlue;

      [JSImport("SplashKitBackendWASM.color_dark_cyan", "main.js")] 
      public static partial Color DarkCyan;

      [JSImport("SplashKitBackendWASM.color_dark_goldenrod", "main.js")] 
      public static partial Color DarkGoldenrod;

      [JSImport("SplashKitBackendWASM.color_dark_gray", "main.js")] 
      public static partial Color DarkGray;

      [JSImport("SplashKitBackendWASM.color_dark_green", "main.js")] 
      public static partial Color DarkGreen;

      [JSImport("SplashKitBackendWASM.color_dark_khaki", "main.js")] 
      public static partial Color DarkKhaki;

      [JSImport("SplashKitBackendWASM.color_dark_magenta", "main.js")] 
      public static partial Color DarkMagenta;

      [JSImport("SplashKitBackendWASM.color_dark_olive_green", "main.js")] 
      public static partial Color DarkOliveGreen;

      [JSImport("SplashKitBackendWASM.color_dark_orange", "main.js")] 
      public static partial Color DarkOrange;

      [JSImport("SplashKitBackendWASM.color_dark_orchid", "main.js")] 
      public static partial Color DarkOrchid;

      [JSImport("SplashKitBackendWASM.color_dark_red", "main.js")] 
      public static partial Color DarkRed;

      [JSImport("SplashKitBackendWASM.color_dark_salmon", "main.js")] 
      public static partial Color DarkSalmon;

      [JSImport("SplashKitBackendWASM.color_dark_sea_green", "main.js")] 
      public static partial Color DarkSeaGreen;

      [JSImport("SplashKitBackendWASM.color_dark_slate_blue", "main.js")] 
      public static partial Color DarkSlateBlue;

      [JSImport("SplashKitBackendWASM.color_dark_slate_gray", "main.js")] 
      public static partial Color DarkSlateGray;

      [JSImport("SplashKitBackendWASM.color_dark_turquoise", "main.js")] 
      public static partial Color DarkTurquoise;

      [JSImport("SplashKitBackendWASM.color_dark_violet", "main.js")] 
      public static partial Color DarkViolet;

      [JSImport("SplashKitBackendWASM.color_deep_pink", "main.js")] 
      public static partial Color DeepPink;

      [JSImport("SplashKitBackendWASM.color_deep_sky_blue", "main.js")] 
      public static partial Color DeepSkyBlue;

      [JSImport("SplashKitBackendWASM.color_dim_gray", "main.js")] 
      public static partial Color DimGray;

      [JSImport("SplashKitBackendWASM.color_dodger_blue", "main.js")] 
      public static partial Color DodgerBlue;

      [JSImport("SplashKitBackendWASM.color_firebrick", "main.js")] 
      public static partial Color Firebrick;

      [JSImport("SplashKitBackendWASM.color_floral_white", "main.js")] 
      public static partial Color FloralWhite;

      [JSImport("SplashKitBackendWASM.color_forest_green", "main.js")] 
      public static partial Color ForestGreen;

      [JSImport("SplashKitBackendWASM.color_fuchsia", "main.js")] 
      public static partial Color Fuchsia;

      [JSImport("SplashKitBackendWASM.color_gainsboro", "main.js")] 
      public static partial Color Gainsboro;

      [JSImport("SplashKitBackendWASM.color_ghost_white", "main.js")] 
      public static partial Color GhostWhite;

      [JSImport("SplashKitBackendWASM.color_gold", "main.js")] 
      public static partial Color Gold;

      [JSImport("SplashKitBackendWASM.color_goldenrod", "main.js")] 
      public static partial Color Goldenrod;

      [JSImport("SplashKitBackendWASM.color_gray", "main.js")] 
      public static partial Color Gray;

      [JSImport("SplashKitBackendWASM.color_green", "main.js")] 
      public static partial Color Green;

      [JSImport("SplashKitBackendWASM.color_green_yellow", "main.js")] 
      public static partial Color GreenYellow;

      [JSImport("SplashKitBackendWASM.color_honeydew", "main.js")] 
      public static partial Color Honeydew;

      [JSImport("SplashKitBackendWASM.color_hot_pink", "main.js")] 
      public static partial Color HotPink;

      [JSImport("SplashKitBackendWASM.color_indian_red", "main.js")] 
      public static partial Color IndianRed;

      [JSImport("SplashKitBackendWASM.color_indigo", "main.js")] 
      public static partial Color Indigo;

      [JSImport("SplashKitBackendWASM.color_ivory", "main.js")] 
      public static partial Color Ivory;

      [JSImport("SplashKitBackendWASM.color_khaki", "main.js")] 
      public static partial Color Khaki;

      [JSImport("SplashKitBackendWASM.color_lavender", "main.js")] 
      public static partial Color Lavender;

      [JSImport("SplashKitBackendWASM.color_lavender_blush", "main.js")] 
      public static partial Color LavenderBlush;

      [JSImport("SplashKitBackendWASM.color_lawn_green", "main.js")] 
      public static partial Color LawnGreen;

      [JSImport("SplashKitBackendWASM.color_lemon_chiffon", "main.js")] 
      public static partial Color LemonChiffon;

      [JSImport("SplashKitBackendWASM.color_light_blue", "main.js")] 
      public static partial Color LightBlue;

      [JSImport("SplashKitBackendWASM.color_light_coral", "main.js")] 
      public static partial Color LightCoral;

      [JSImport("SplashKitBackendWASM.color_light_cyan", "main.js")] 
      public static partial Color LightCyan;

      [JSImport("SplashKitBackendWASM.color_light_goldenrod_yellow", "main.js")] 
      public static partial Color LightGoldenrodYellow;

      [JSImport("SplashKitBackendWASM.color_light_gray", "main.js")] 
      public static partial Color LightGray;

      [JSImport("SplashKitBackendWASM.color_light_green", "main.js")] 
      public static partial Color LightGreen;

      [JSImport("SplashKitBackendWASM.color_light_pink", "main.js")] 
      public static partial Color LightPink;

      [JSImport("SplashKitBackendWASM.color_light_salmon", "main.js")] 
      public static partial Color LightSalmon;

      [JSImport("SplashKitBackendWASM.color_light_sea_green", "main.js")] 
      public static partial Color LightSeaGreen;

      [JSImport("SplashKitBackendWASM.color_light_sky_blue", "main.js")] 
      public static partial Color LightSkyBlue;

      [JSImport("SplashKitBackendWASM.color_light_slate_gray", "main.js")] 
      public static partial Color LightSlateGray;

      [JSImport("SplashKitBackendWASM.color_light_steel_blue", "main.js")] 
      public static partial Color LightSteelBlue;

      [JSImport("SplashKitBackendWASM.color_light_yellow", "main.js")] 
      public static partial Color LightYellow;

      [JSImport("SplashKitBackendWASM.color_lime", "main.js")] 
      public static partial Color Lime;

      [JSImport("SplashKitBackendWASM.color_lime_green", "main.js")] 
      public static partial Color LimeGreen;

      [JSImport("SplashKitBackendWASM.color_linen", "main.js")] 
      public static partial Color Linen;

      [JSImport("SplashKitBackendWASM.color_magenta", "main.js")] 
      public static partial Color Magenta;

      [JSImport("SplashKitBackendWASM.color_maroon", "main.js")] 
      public static partial Color Maroon;

      [JSImport("SplashKitBackendWASM.color_medium_aquamarine", "main.js")] 
      public static partial Color MediumAquamarine;

      [JSImport("SplashKitBackendWASM.color_medium_blue", "main.js")] 
      public static partial Color MediumBlue;

      [JSImport("SplashKitBackendWASM.color_medium_orchid", "main.js")] 
      public static partial Color MediumOrchid;

      [JSImport("SplashKitBackendWASM.color_medium_purple", "main.js")] 
      public static partial Color MediumPurple;

      [JSImport("SplashKitBackendWASM.color_medium_sea_green", "main.js")] 
      public static partial Color MediumSeaGreen;

      [JSImport("SplashKitBackendWASM.color_medium_slate_blue", "main.js")] 
      public static partial Color MediumSlateBlue;

      [JSImport("SplashKitBackendWASM.color_medium_spring_green", "main.js")] 
      public static partial Color MediumSpringGreen;

      [JSImport("SplashKitBackendWASM.color_medium_turquoise", "main.js")] 
      public static partial Color MediumTurquoise;

      [JSImport("SplashKitBackendWASM.color_medium_violet_red", "main.js")] 
      public static partial Color MediumVioletRed;

      [JSImport("SplashKitBackendWASM.color_midnight_blue", "main.js")] 
      public static partial Color MidnightBlue;

      [JSImport("SplashKitBackendWASM.color_mint_cream", "main.js")] 
      public static partial Color MintCream;

      [JSImport("SplashKitBackendWASM.color_misty_rose", "main.js")] 
      public static partial Color MistyRose;

      [JSImport("SplashKitBackendWASM.color_moccasin", "main.js")] 
      public static partial Color Moccasin;

      [JSImport("SplashKitBackendWASM.color_navajo_white", "main.js")] 
      public static partial Color NavajoWhite;

      [JSImport("SplashKitBackendWASM.color_navy", "main.js")] 
      public static partial Color Navy;

      [JSImport("SplashKitBackendWASM.color_old_lace", "main.js")] 
      public static partial Color OldLace;

      [JSImport("SplashKitBackendWASM.color_olive", "main.js")] 
      public static partial Color Olive;

      [JSImport("SplashKitBackendWASM.color_olive_drab", "main.js")] 
      public static partial Color OliveDrab;

      [JSImport("SplashKitBackendWASM.color_orange", "main.js")] 
      public static partial Color Orange;

      [JSImport("SplashKitBackendWASM.color_orange_red", "main.js")] 
      public static partial Color OrangeRed;

      [JSImport("SplashKitBackendWASM.color_orchid", "main.js")] 
      public static partial Color Orchid;

      [JSImport("SplashKitBackendWASM.color_pale_goldenrod", "main.js")] 
      public static partial Color PaleGoldenrod;

      [JSImport("SplashKitBackendWASM.color_pale_green", "main.js")] 
      public static partial Color PaleGreen;

      [JSImport("SplashKitBackendWASM.color_pale_turquoise", "main.js")] 
      public static partial Color PaleTurquoise;

      [JSImport("SplashKitBackendWASM.color_pale_violet_red", "main.js")] 
      public static partial Color PaleVioletRed;

      [JSImport("SplashKitBackendWASM.color_papaya_whip", "main.js")] 
      public static partial Color PapayaWhip;

      [JSImport("SplashKitBackendWASM.color_peach_puff", "main.js")] 
      public static partial Color PeachPuff;

      [JSImport("SplashKitBackendWASM.color_peru", "main.js")] 
      public static partial Color Peru;

      [JSImport("SplashKitBackendWASM.color_pink", "main.js")] 
      public static partial Color Pink;

      [JSImport("SplashKitBackendWASM.color_plum", "main.js")] 
      public static partial Color Plum;

      [JSImport("SplashKitBackendWASM.color_powder_blue", "main.js")] 
      public static partial Color PowderBlue;

      [JSImport("SplashKitBackendWASM.color_purple", "main.js")] 
      public static partial Color Purple;

      [JSImport("SplashKitBackendWASM.color_red", "main.js")] 
      public static partial Color Red;

      [JSImport("SplashKitBackendWASM.color_rosy_brown", "main.js")] 
      public static partial Color RosyBrown;

      [JSImport("SplashKitBackendWASM.color_royal_blue", "main.js")] 
      public static partial Color RoyalBlue;

      [JSImport("SplashKitBackendWASM.color_saddle_brown", "main.js")] 
      public static partial Color SaddleBrown;

      [JSImport("SplashKitBackendWASM.color_salmon", "main.js")] 
      public static partial Color Salmon;

      [JSImport("SplashKitBackendWASM.color_sandy_brown", "main.js")] 
      public static partial Color SandyBrown;

      [JSImport("SplashKitBackendWASM.color_sea_green", "main.js")] 
      public static partial Color SeaGreen;

      [JSImport("SplashKitBackendWASM.color_sea_shell", "main.js")] 
      public static partial Color SeaShell;

      [JSImport("SplashKitBackendWASM.color_sienna", "main.js")] 
      public static partial Color Sienna;

      [JSImport("SplashKitBackendWASM.color_silver", "main.js")] 
      public static partial Color Silver;

      [JSImport("SplashKitBackendWASM.color_sky_blue", "main.js")] 
      public static partial Color SkyBlue;

      [JSImport("SplashKitBackendWASM.color_slate_blue", "main.js")] 
      public static partial Color SlateBlue;

      [JSImport("SplashKitBackendWASM.color_slate_gray", "main.js")] 
      public static partial Color SlateGray;

      [JSImport("SplashKitBackendWASM.color_snow", "main.js")] 
      public static partial Color Snow;

      [JSImport("SplashKitBackendWASM.color_spring_green", "main.js")] 
      public static partial Color SpringGreen;

      [JSImport("SplashKitBackendWASM.color_steel_blue", "main.js")] 
      public static partial Color SteelBlue;

      [JSImport("SplashKitBackendWASM.color_swinburne_red", "main.js")] 
      public static partial Color SwinburneRed;

      [JSImport("SplashKitBackendWASM.color_tan", "main.js")] 
      public static partial Color Tan;

      [JSImport("SplashKitBackendWASM.color_teal", "main.js")] 
      public static partial Color Teal;

      [JSImport("SplashKitBackendWASM.color_thistle", "main.js")] 
      public static partial Color Thistle;

      [JSImport("SplashKitBackendWASM.color_tomato", "main.js")] 
      public static partial Color Tomato;

      [JSImport("SplashKitBackendWASM.color_transparent", "main.js")] 
      public static partial Color Transparent;

      [JSImport("SplashKitBackendWASM.color_turquoise", "main.js")] 
      public static partial Color Turquoise;

      [JSImport("SplashKitBackendWASM.color_violet", "main.js")] 
      public static partial Color Violet;

      [JSImport("SplashKitBackendWASM.color_wheat", "main.js")] 
      public static partial Color Wheat;

      [JSImport("SplashKitBackendWASM.color_white", "main.js")] 
      public static partial Color White;

      [JSImport("SplashKitBackendWASM.color_white_smoke", "main.js")] 
      public static partial Color WhiteSmoke;

      [JSImport("SplashKitBackendWASM.color_yellow", "main.js")] 
      public static partial Color Yellow;

      [JSImport("SplashKitBackendWASM.color_yellow_green", "main.js")] 
      public static partial Color YellowGreen;

      [JSImport("SplashKitBackendWASM.hsb_color", "main.js")] 
      public static partial Color HSBColor(double hue, double saturation, double brightness);

      [JSImport("SplashKitBackendWASM.random_color", "main.js")] 
      public static partial Color Random();

      [JSImport("SplashKitBackendWASM.random_rgb_color", "main.js")] 
      public static partial Color RandomRGB(int alpha);

      [JSImport("SplashKitBackendWASM.rgb_color", "main.js")] 
      public static partial Color RGBColor(double red, double green, double blue);

      [JSImport("SplashKitBackendWASM.rgb_color", "main.js")] 
      public static partial Color RGBColor(int red, int green, int blue);

      [JSImport("SplashKitBackendWASM.rgba_color", "main.js")] 
      public static partial Color RGBAColor(double red, double green, double blue, double alpha);

      [JSImport("SplashKitBackendWASM.rgba_color", "main.js")] 
      public static partial Color RGBAColor(int red, int green, int blue, int alpha);

     } 

   public partial class Circle
   {
      [JSImport("SplashKitBackendWASM.draw_circle", "main.js")] 
      public partial void Draw(Color clr);

      [JSImport("SplashKitBackendWASM.draw_circle", "main.js")] 
      public partial void Draw(Color clr, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_circle", "main.js")] 
      public partial void Fill(Color clr);

      [JSImport("SplashKitBackendWASM.fill_circle", "main.js")] 
      public partial void Fill(Color clr, DrawingOptions opts);

     } 

   public partial class Bitmap
   {
      [JSImport("SplashKitBackendWASM.draw_circle_on_bitmap", "main.js")] 
      public partial void DrawCircle(Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.draw_circle_on_bitmap", "main.js")] 
      public partial void DrawCircle(Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_circle_on_bitmap", "main.js")] 
      public partial void FillCircle(Color clr, double x, double y, double radius);

      [JSImport("SplashKitBackendWASM.fill_circle_on_bitmap", "main.js")] 
      public partial void FillCircle(Color clr, double x, double y, double radius, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_bitmap", "main.js")] 
      public partial void DrawEllipse(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_bitmap", "main.js")] 
      public partial void DrawEllipse(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_bitmap", "main.js")] 
      public partial void DrawEllipse(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_ellipse_on_bitmap", "main.js")] 
      public partial void DrawEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_bitmap", "main.js")] 
      public partial void FillEllipse(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_bitmap", "main.js")] 
      public partial void FillEllipse(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_bitmap", "main.js")] 
      public partial void FillEllipse(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_ellipse_on_bitmap", "main.js")] 
      public partial void FillEllipse(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.bitmap_bounding_circle", "main.js")] 
      public partial Circle BoundingCircle(Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_bounding_rectangle", "main.js")] 
      public partial Rectangle BoundingRectangle();

      [JSImport("SplashKitBackendWASM.bitmap_bounding_rectangle", "main.js")] 
      public partial Rectangle BoundingRectangle(double x, double y);

      [JSImport("SplashKitBackendWASM.bitmap_cell_center", "main.js")] 
      public partial Point2D CellCenter;

      [JSImport("SplashKitBackendWASM.bitmap_cell_circle", "main.js")] 
      public partial Circle CellCircle(double x, double y);

      [JSImport("SplashKitBackendWASM.bitmap_cell_circle", "main.js")] 
      public partial Circle CellCircle(Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_cell_circle", "main.js")] 
      public partial Circle CellCircle(Point2D pt, double scale);

      [JSImport("SplashKitBackendWASM.bitmap_cell_columns", "main.js")] 
      public partial int CellColumns;

      [JSImport("SplashKitBackendWASM.bitmap_cell_count", "main.js")] 
      public partial int CellCount;

      [JSImport("SplashKitBackendWASM.bitmap_cell_height", "main.js")] 
      public partial int CellHeight;

      [JSImport("SplashKitBackendWASM.bitmap_cell_offset", "main.js")] 
      public partial Vector2D CellOffset(int cell);

      [JSImport("SplashKitBackendWASM.bitmap_cell_rectangle", "main.js")] 
      public partial Rectangle CellRectangle();

      [JSImport("SplashKitBackendWASM.bitmap_cell_rectangle", "main.js")] 
      public partial Rectangle CellRectangle(Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_cell_rows", "main.js")] 
      public partial int CellRows;

      [JSImport("SplashKitBackendWASM.bitmap_cell_width", "main.js")] 
      public partial int CellWidth;

      [JSImport("SplashKitBackendWASM.bitmap_center", "main.js")] 
      public partial Point2D Center;

      [JSImport("SplashKitBackendWASM.bitmap_filename", "main.js")] 
      public partial string Filename;

      [JSImport("SplashKitBackendWASM.bitmap_height", "main.js")] 
      public partial int Height;

      [JSImport("SplashKitBackendWASM.bitmap_name", "main.js")] 
      public partial string Name;

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_of_cell", "main.js")] 
      public partial Rectangle RectangleOfCell(int cell);

      [JSImport("SplashKitBackendWASM.bitmap_set_cell_details", "main.js")] 
      public partial void SetCellDetails(int width, int height, int columns, int rows, int count);

      [JSImport("SplashKitBackendWASM.bitmap_width", "main.js")] 
      public partial int Width;

      [JSImport("SplashKitBackendWASM.clear_bitmap", "main.js")] 
      public partial void Clear(Color clr);

      [JSImport("SplashKitBackendWASM.draw_bitmap", "main.js")] 
      public partial void Draw(double x, double y);

      [JSImport("SplashKitBackendWASM.draw_bitmap", "main.js")] 
      public partial void Draw(double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_bitmap_on_bitmap", "main.js")] 
      public partial void DrawBitmap(Bitmap destination, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_bitmap_on_bitmap", "main.js")] 
      public partial void DrawBitmap(Bitmap destination, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.free_bitmap", "main.js")] 
      public partial void Free();

      [JSImport("SplashKitBackendWASM.pixel_drawn_at_point", "main.js")] 
      public partial bool PixelDrawnAtPoint(Point2D pt);

      [JSImport("SplashKitBackendWASM.pixel_drawn_at_point", "main.js")] 
      public partial bool PixelDrawnAtPoint(double x, double y);

      [JSImport("SplashKitBackendWASM.pixel_drawn_at_point", "main.js")] 
      public partial bool PixelDrawnAtPointInCell(int cell, Point2D pt);

      [JSImport("SplashKitBackendWASM.pixel_drawn_at_point", "main.js")] 
      public partial bool PixelDrawnAtPoint(int cell, double x, double y);

      [JSImport("SplashKitBackendWASM.setup_collision_mask", "main.js")] 
      public partial void SetupCollisionMask();

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public partial void DrawLine(Color clr, Line l);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public partial void DrawLine(Color clr, Line l, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public partial void DrawLine(Color clr, Point2D fromPt, Point2D toPt);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public partial void DrawLine(Color clr, Point2D fromPt, Point2D toPt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public partial void DrawLine(Color clr, double x1, double y1, double x2, double y2);

      [JSImport("SplashKitBackendWASM.draw_line_on_bitmap", "main.js")] 
      public partial void DrawLine(Color clr, double x1, double y1, double x2, double y2, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_bitmap", "main.js")] 
      public partial void DrawPixel(Color clr, Point2D pt);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_bitmap", "main.js")] 
      public partial void DrawPixel(Color clr, Point2D pt, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_bitmap", "main.js")] 
      public partial void DrawPixel(Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_pixel_on_bitmap", "main.js")] 
      public partial void DrawPixel(Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_quad_on_bitmap", "main.js")] 
      public partial void DrawQuad(Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.draw_quad_on_bitmap", "main.js")] 
      public partial void DrawQuad(Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_bitmap", "main.js")] 
      public partial void DrawRectangle(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_bitmap", "main.js")] 
      public partial void DrawRectangle(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_bitmap", "main.js")] 
      public partial void DrawRectangle(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.draw_rectangle_on_bitmap", "main.js")] 
      public partial void DrawRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_quad_on_bitmap", "main.js")] 
      public partial void FillQuad(Color clr, Quad q);

      [JSImport("SplashKitBackendWASM.fill_quad_on_bitmap", "main.js")] 
      public partial void FillQuad(Color clr, Quad q, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_bitmap", "main.js")] 
      public partial void FillRectangle(Color clr, Rectangle rect);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_bitmap", "main.js")] 
      public partial void FillRectangle(Color clr, Rectangle rect, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_bitmap", "main.js")] 
      public partial void FillRectangle(Color clr, double x, double y, double width, double height);

      [JSImport("SplashKitBackendWASM.fill_rectangle_on_bitmap", "main.js")] 
      public partial void FillRectangle(Color clr, double x, double y, double width, double height, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public partial void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public partial void DrawText(string text, Color clr, string fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public partial void DrawText(string text, Color clr, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public partial void DrawText(string text, Color clr, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public partial void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y);

      [JSImport("SplashKitBackendWASM.draw_text_on_bitmap", "main.js")] 
      public partial void DrawText(string text, Color clr, Font fnt, int fontSize, double x, double y, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_bitmap", "main.js")] 
      public partial void DrawTriangle(Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_bitmap", "main.js")] 
      public partial void DrawTriangle(Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_bitmap", "main.js")] 
      public partial void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.draw_triangle_on_bitmap", "main.js")] 
      public partial void DrawTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_bitmap", "main.js")] 
      public partial void FillTriangle(Color clr, Triangle tri);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_bitmap", "main.js")] 
      public partial void FillTriangle(Color clr, Triangle tri, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_bitmap", "main.js")] 
      public partial void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3);

      [JSImport("SplashKitBackendWASM.fill_triangle_on_bitmap", "main.js")] 
      public partial void FillTriangle(Color clr, double x1, double y1, double x2, double y2, double x3, double y3, DrawingOptions opts);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public partial bool CircleCollision(Point2D pt, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public partial bool CircleCollision(double x, double y, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public partial bool CircleCollision(int cell, Matrix2D translation, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public partial bool CircleCollision(int cell, Point2D pt, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_circle_collision", "main.js")] 
      public partial bool CircleCollision(int cell, double x, double y, Circle circ);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public partial bool BitmapCollision(double x1, double y1, Bitmap bmp2, double x2, double y2);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public partial bool BitmapCollision(Point2D pt1, Bitmap bmp2, Point2D pt2);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public partial bool BitmapCollision(int cell1, Matrix2D matrix1, Bitmap bmp2, int cell2, Matrix2D matrix2);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public partial bool BitmapCollision(int cell1, Point2D pt1, Bitmap bmp2, int cell2, Point2D pt2);

      [JSImport("SplashKitBackendWASM.bitmap_collision", "main.js")] 
      public partial bool BitmapCollision(int cell1, double x1, double y1, Bitmap bmp2, int cell2, double x2, double y2);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public partial bool PointCollision(Matrix2D translation, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public partial bool PointCollision(Point2D bmpPt, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public partial bool PointCollision(double bmpX, double bmpY, double x, double y);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public partial bool PointCollision(int cell, Matrix2D translation, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public partial bool PointCollision(int cell, Point2D bmpPt, Point2D pt);

      [JSImport("SplashKitBackendWASM.bitmap_point_collision", "main.js")] 
      public partial bool PointCollision(int cell, double bmpX, double bmpY, double x, double y);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public partial bool QuadCollision(Point2D pt, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public partial bool QuadCollision(double x, double y, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public partial bool QuadCollision(int cell, Matrix2D translation, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public partial bool QuadCollision(int cell, Point2D pt, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_quad_collision", "main.js")] 
      public partial bool QuadCollision(int cell, double x, double y, Quad q);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public partial bool RayCollision(Point2D pt, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public partial bool RayCollision(double x, double y, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public partial bool RayCollision(int cell, Matrix2D translation, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public partial bool RayCollision(int cell, Point2D pt, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_ray_collision", "main.js")] 
      public partial bool RayCollision(int cell, double x, double y, Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public partial bool RectangleCollision(Point2D pt, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public partial bool RectangleCollision(double x, double y, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public partial bool RectangleCollision(int cell, Matrix2D translation, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public partial bool RectangleCollision(int cell, Point2D pt, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_rectangle_collision", "main.js")] 
      public partial bool RectangleCollision(int cell, double x, double y, Rectangle rect);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public partial bool TriangleCollision(Point2D pt, Triangle tri);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public partial bool TriangleCollision(double x, double y, Triangle tri);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public partial bool TriangleCollision(int cell, Matrix2D translation, Triangle tri);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public partial bool TriangleCollision(int cell, Point2D pt, Triangle tri);

      [JSImport("SplashKitBackendWASM.bitmap_triangle_collision", "main.js")] 
      public partial bool TriangleCollision(int cell, double x, double y, Triangle tri);

     } 

   public partial class Display
   {
      [JSImport("SplashKitBackendWASM.display_height", "main.js")] 
      public partial int Height;

      [JSImport("SplashKitBackendWASM.display_name", "main.js")] 
      public partial string Name;

      [JSImport("SplashKitBackendWASM.display_width", "main.js")] 
      public partial int Width;

      [JSImport("SplashKitBackendWASM.display_x", "main.js")] 
      public partial int X;

      [JSImport("SplashKitBackendWASM.display_y", "main.js")] 
      public partial int Y;

     } 

   public partial class Font
   {
      [JSImport("SplashKitBackendWASM.font_has_size", "main.js")] 
      public partial bool HasSize(int fontSize);

      [JSImport("SplashKitBackendWASM.font_load_size", "main.js")] 
      public partial void LoadSize(int fontSize);

      [JSImport("SplashKitBackendWASM.free_font", "main.js")] 
      public partial void Free();

      [JSImport("SplashKitBackendWASM.get_font_style", "main.js")] 
      public partial FontStyle Style;

      [JSImport("SplashKitBackendWASM.set_font_style", "main.js")] 
      public partial void Style;

     } 

   public partial class Text
   {
      [JSImport("SplashKitBackendWASM.free_all_fonts", "main.js")] 
      public static partial void FreeAll();

      [JSImport("SplashKitBackendWASM.text_height", "main.js")] 
      public static partial int Height(string text, string fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.text_height", "main.js")] 
      public static partial int Height(string text, Font fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.text_width", "main.js")] 
      public static partial int Width(string text, string fnt, int fontSize);

      [JSImport("SplashKitBackendWASM.text_width", "main.js")] 
      public static partial int Width(string text, Font fnt, int fontSize);

     } 

   public partial class Json
   {
      [JSImport("SplashKitBackendWASM.free_all_json", "main.js")] 
      public static partial void FreeAll();

      [JSImport("SplashKitBackendWASM.free_json", "main.js")] 
      public partial void Free();

      [JSImport("SplashKitBackendWASM.json_count_keys", "main.js")] 
      public partial int CountKeys();

      [JSImport("SplashKitBackendWASM.json_from_file", "main.js")] 
      public static partial Json FromFile(string filename);

      [JSImport("SplashKitBackendWASM.json_from_string", "main.js")] 
      public static partial Json FromJsonString(string jString);

      [JSImport("SplashKitBackendWASM.json_has_key", "main.js")] 
      public partial bool HasKey(string key);

      [JSImport("SplashKitBackendWASM.json_read_array", "main.js")] 
      public partial void ReadArray(string key, ref List<double> outResult);

      [JSImport("SplashKitBackendWASM.json_read_array", "main.js")] 
      public partial void ReadArray(string key, ref List<Json> outResult);

      [JSImport("SplashKitBackendWASM.json_read_array", "main.js")] 
      public partial void ReadArray(string key, ref List<string> outResult);

      [JSImport("SplashKitBackendWASM.json_read_array", "main.js")] 
      public partial void ReadArray(string key, ref List<bool> outResult);

      [JSImport("SplashKitBackendWASM.json_read_bool", "main.js")] 
      public partial bool ReadBool(string key);

      [JSImport("SplashKitBackendWASM.json_read_number", "main.js")] 
      public partial float ReadNumber(string key);

      [JSImport("SplashKitBackendWASM.json_read_number_as_double", "main.js")] 
      public partial double ReadDouble(string key);

      [JSImport("SplashKitBackendWASM.json_read_number_as_int", "main.js")] 
      public partial int ReadInteger(string key);

      [JSImport("SplashKitBackendWASM.json_read_object", "main.js")] 
      public partial Json ReadObject(string key);

      [JSImport("SplashKitBackendWASM.json_read_string", "main.js")] 
      public partial string ReadString(string key);

      [JSImport("SplashKitBackendWASM.json_set_array", "main.js")] 
      public partial void AddArray(string key, List<string> value);

      [JSImport("SplashKitBackendWASM.json_set_array", "main.js")] 
      public partial void AddArray(string key, List<double> value);

      [JSImport("SplashKitBackendWASM.json_set_array", "main.js")] 
      public partial void AddArray(string key, List<bool> value);

      [JSImport("SplashKitBackendWASM.json_set_array", "main.js")] 
      public partial void AddArray(string key, List<Json> value);

      [JSImport("SplashKitBackendWASM.json_set_bool", "main.js")] 
      public partial void AddBool(string key, bool value);

      [JSImport("SplashKitBackendWASM.json_set_number", "main.js")] 
      public partial void AddNumber(string key, int value);

      [JSImport("SplashKitBackendWASM.json_set_number", "main.js")] 
      public partial void AddNumber(string key, double value);

      [JSImport("SplashKitBackendWASM.json_set_number", "main.js")] 
      public partial void AddNumber(string key, float value);

      [JSImport("SplashKitBackendWASM.json_set_object", "main.js")] 
      public partial void AddObject(string key, Json obj);

      [JSImport("SplashKitBackendWASM.json_set_string", "main.js")] 
      public partial void AddString(string key, string value);

      [JSImport("SplashKitBackendWASM.json_to_file", "main.js")] 
      public static partial void ToFile(Json j, string filename);

      [JSImport("SplashKitBackendWASM.json_to_string", "main.js")] 
      public static partial string ToJsonString(Json j);

     } 

   public partial class ServerSocket
   {
      [JSImport("SplashKitBackendWASM.accept_new_connection", "main.js")] 
      public partial bool AcceptNewConnection();

      [JSImport("SplashKitBackendWASM.broadcast_message", "main.js")] 
      public partial void BroadcastMessage(string aMsg);

      [JSImport("SplashKitBackendWASM.clear_messages", "main.js")] 
      public partial void ClearMessages();

      [JSImport("SplashKitBackendWASM.close_server", "main.js")] 
      public partial bool Close();

      [JSImport("SplashKitBackendWASM.connection_count", "main.js")] 
      public partial uint ConnectionCount;

      [JSImport("SplashKitBackendWASM.fetch_new_connection", "main.js")] 
      public partial Connection FetchNewConnection();

      [JSImport("SplashKitBackendWASM.has_messages", "main.js")] 
      public partial bool HasMessages;

      [JSImport("SplashKitBackendWASM.last_connection", "main.js")] 
      public partial Connection LastConnection;

      [JSImport("SplashKitBackendWASM.message_count", "main.js")] 
      public partial uint MessageCount;

      [JSImport("SplashKitBackendWASM.new_connection_count", "main.js")] 
      public partial int NewConnectionCount;

      [JSImport("SplashKitBackendWASM.read_message", "main.js")] 
      public partial Message ReadMessage();

      [JSImport("SplashKitBackendWASM.read_message_data", "main.js")] 
      public partial string ReadMessageData();

      [JSImport("SplashKitBackendWASM.reset_new_connection_count", "main.js")] 
      public partial void ResetNewConnectionCount();

      [JSImport("SplashKitBackendWASM.retrieve_connection", "main.js")] 
      public partial Connection RetrieveConnection(int idx);

      [JSImport("SplashKitBackendWASM.server_has_new_connection", "main.js")] 
      public partial bool HasNewConnections;

     } 

   public partial class Connection
   {
      [JSImport("SplashKitBackendWASM.clear_messages", "main.js")] 
      public partial void ClearMessages();

      [JSImport("SplashKitBackendWASM.close_connection", "main.js")] 
      public partial bool Close();

      [JSImport("SplashKitBackendWASM.connection_ip", "main.js")] 
      public partial uint IP;

      [JSImport("SplashKitBackendWASM.connection_port", "main.js")] 
      public partial ushort Port;

      [JSImport("SplashKitBackendWASM.has_messages", "main.js")] 
      public partial bool HasMessages;

      [JSImport("SplashKitBackendWASM.is_connection_open", "main.js")] 
      public partial bool IsOpen;

      [JSImport("SplashKitBackendWASM.message_count", "main.js")] 
      public partial uint MessageCount;

      [JSImport("SplashKitBackendWASM.read_message", "main.js")] 
      public partial Message ReadMessage();

      [JSImport("SplashKitBackendWASM.read_message_data", "main.js")] 
      public partial string ReadMessageData();

      [JSImport("SplashKitBackendWASM.reconnect", "main.js")] 
      public partial void Reconnect();

      [JSImport("SplashKitBackendWASM.send_message_to", "main.js")] 
      public partial bool SendMessage(string aMsg);

     } 

   public partial class Message
   {
      [JSImport("SplashKitBackendWASM.close_message", "main.js")] 
      public partial void Close();

      [JSImport("SplashKitBackendWASM.message_data", "main.js")] 
      public partial string Data;

      [JSImport("SplashKitBackendWASM.message_data_bytes", "main.js")] 
      public partial List<byte> DataBytes;

      [JSImport("SplashKitBackendWASM.message_host", "main.js")] 
      public partial string Host;

      [JSImport("SplashKitBackendWASM.message_port", "main.js")] 
      public partial ushort Port;

      [JSImport("SplashKitBackendWASM.message_protocol", "main.js")] 
      public partial ConnectionType Protocol;

     } 

   public partial class Networking
   {
      [JSImport("SplashKitBackendWASM.has_messages", "main.js")] 
      public static partial bool HasMessages;

      [JSImport("SplashKitBackendWASM.set_udp_packet_size", "main.js")] 
      public static partial void UDPPacketSize;

      [JSImport("SplashKitBackendWASM.udp_packet_size", "main.js")] 
      public static partial uint UDPPacketSize;

     } 

   public partial class HttpResponse
   {
      [JSImport("SplashKitBackendWASM.free_response", "main.js")] 
      public partial void Free();

     } 

   public partial class WebServer
   {
      [JSImport("SplashKitBackendWASM.has_incoming_requests", "main.js")] 
      public partial bool HasIncomingRequests;

      [JSImport("SplashKitBackendWASM.next_web_request", "main.js")] 
      public partial HttpRequest NextWebRequest;

      [JSImport("SplashKitBackendWASM.stop_web_server", "main.js")] 
      public partial void Stop();

     } 

   public partial class HttpRequest
   {
      [JSImport("SplashKitBackendWASM.is_delete_request_for", "main.js")] 
      public partial bool IsDeleteRequestFor(string path);

      [JSImport("SplashKitBackendWASM.is_get_request_for", "main.js")] 
      public partial bool IsGetRequestFor(string path);

      [JSImport("SplashKitBackendWASM.is_options_request_for", "main.js")] 
      public partial bool IsOptionsRequestFor(string path);

      [JSImport("SplashKitBackendWASM.is_post_request_for", "main.js")] 
      public partial bool IsPostRequestFor(string path);

      [JSImport("SplashKitBackendWASM.is_put_request_for", "main.js")] 
      public partial bool IsPutRequestFor(string path);

      [JSImport("SplashKitBackendWASM.is_request_for", "main.js")] 
      public partial bool IsRequestFor(HttpMethod method, string path);

      [JSImport("SplashKitBackendWASM.is_trace_request_for", "main.js")] 
      public partial bool IsTraceRequestFor(string path);

      [JSImport("SplashKitBackendWASM.request_body", "main.js")] 
      public partial string Body;

      [JSImport("SplashKitBackendWASM.request_has_query_parameter", "main.js")] 
      public partial bool HasQueryParameter(string name);

      [JSImport("SplashKitBackendWASM.request_headers", "main.js")] 
      public partial List<string> Headers;

      [JSImport("SplashKitBackendWASM.request_method", "main.js")] 
      public partial HttpMethod Method;

      [JSImport("SplashKitBackendWASM.request_query_parameter", "main.js")] 
      public partial string QueryParameter(string name, string defaultValue);

      [JSImport("SplashKitBackendWASM.request_query_string", "main.js")] 
      public partial string QueryString;

      [JSImport("SplashKitBackendWASM.request_uri", "main.js")] 
      public partial string URI;

      [JSImport("SplashKitBackendWASM.request_uri_stubs", "main.js")] 
      public partial List<string> URIStubs;

      [JSImport("SplashKitBackendWASM.send_css_file_response", "main.js")] 
      public partial void SendCSSFileResponse(string filename);

      [JSImport("SplashKitBackendWASM.send_file_response", "main.js")] 
      public partial void SendFileResponse(string filename, string contentType);

      [JSImport("SplashKitBackendWASM.send_html_file_response", "main.js")] 
      public partial void SendHtmlFileResponse(string filename);

      [JSImport("SplashKitBackendWASM.send_javascript_file_response", "main.js")] 
      public partial void SendJavascriptFileResponse(string filename);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public partial void SendResponse();

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public partial void SendResponse(string message);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public partial void SendResponse(HttpStatusCode code);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public partial void SendResponse(HttpStatusCode code, string message);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public partial void SendResponse(HttpStatusCode code, string message, string contentType);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public partial void SendResponse(HttpStatusCode code, string message, string contentType, List<string> headers);

      [JSImport("SplashKitBackendWASM.send_response", "main.js")] 
      public partial void SendResponse(Json j);

     } 

   public partial class Sprite
   {
      [JSImport("SplashKitBackendWASM.sprite_bitmap_collision", "main.js")] 
      public partial bool BitmapCollision(Bitmap bmp, double x, double y);

      [JSImport("SplashKitBackendWASM.sprite_bitmap_collision", "main.js")] 
      public partial bool BitmapCollision(Bitmap bmp, int cell, Point2D pt);

      [JSImport("SplashKitBackendWASM.sprite_bitmap_collision", "main.js")] 
      public partial bool BitmapCollision(Bitmap bmp, int cell, double x, double y);

      [JSImport("SplashKitBackendWASM.sprite_circle_collision", "main.js")] 
      public partial bool CircleCollision(Circle c);

      [JSImport("SplashKitBackendWASM.sprite_collision", "main.js")] 
      public partial bool SpriteCollision(Sprite s2);

      [JSImport("SplashKitBackendWASM.sprite_point_collision", "main.js")] 
      public partial bool PointCollision(Point2D pt);

      [JSImport("SplashKitBackendWASM.sprite_quad_collision", "main.js")] 
      public partial bool QuadCollision(Quad q);

      [JSImport("SplashKitBackendWASM.sprite_ray_collision", "main.js")] 
      public partial bool RayCollision(Point2D origin, Vector2D heading);

      [JSImport("SplashKitBackendWASM.sprite_rectangle_collision", "main.js")] 
      public partial bool RectangleCollision(Rectangle rect);

      [JSImport("SplashKitBackendWASM.sprite_triangle_collision", "main.js")] 
      public partial bool TriangleCollision(Triangle t);

      [JSImport("SplashKitBackendWASM.draw_sprite", "main.js")] 
      public partial void Draw(Vector2D offset);

      [JSImport("SplashKitBackendWASM.draw_sprite", "main.js")] 
      public partial void Draw();

      [JSImport("SplashKitBackendWASM.draw_sprite", "main.js")] 
      public partial void Draw(double xOffset, double yOffset);

      [JSImport("SplashKitBackendWASM.move_sprite", "main.js")] 
      public partial void Move();

      [JSImport("SplashKitBackendWASM.move_sprite", "main.js")] 
      public partial void Move(Vector2D distance);

      [JSImport("SplashKitBackendWASM.move_sprite", "main.js")] 
      public partial void Move(Vector2D distance, float pct);

      [JSImport("SplashKitBackendWASM.move_sprite", "main.js")] 
      public partial void Move(float pct);

      [JSImport("SplashKitBackendWASM.move_sprite_to", "main.js")] 
      public partial void MoveTo(double x, double y);

      [JSImport("SplashKitBackendWASM.sprite_add_layer", "main.js")] 
      public partial int AddLayer(Bitmap newLayer, string layerName);

      [JSImport("SplashKitBackendWASM.sprite_add_to_velocity", "main.js")] 
      public partial void AddToVelocity(Vector2D value);

      [JSImport("SplashKitBackendWASM.sprite_add_value", "main.js")] 
      public partial void AddValue(string name);

      [JSImport("SplashKitBackendWASM.sprite_add_value", "main.js")] 
      public partial void AddValue(string name, float initVal);

      [JSImport("SplashKitBackendWASM.sprite_anchor_point", "main.js")] 
      public partial Point2D AnchorPoint;

      [JSImport("SplashKitBackendWASM.sprite_animation_has_ended", "main.js")] 
      public partial bool AnimationHasEnded;

      [JSImport("SplashKitBackendWASM.sprite_animation_name", "main.js")] 
      public partial string AnimationName();

      [JSImport("SplashKitBackendWASM.sprite_bring_layer_forward", "main.js")] 
      public partial void SendLayerForward(int visibleLayer);

      [JSImport("SplashKitBackendWASM.sprite_bring_layer_to_front", "main.js")] 
      public partial void SendLayerTofront(int visibleLayer);

      [JSImport("SplashKitBackendWASM.sprite_call_on_event", "main.js")] 
      public partial void CallOnEvent(SpriteEventHandler handler);

      [JSImport("SplashKitBackendWASM.sprite_center_point", "main.js")] 
      public partial Point2D SpriteCenterPoint;

      [JSImport("SplashKitBackendWASM.sprite_circle", "main.js")] 
      public partial Circle Circle();

      [JSImport("SplashKitBackendWASM.sprite_collision_bitmap", "main.js")] 
      public partial Bitmap CollisionBitmap;

      [JSImport("SplashKitBackendWASM.sprite_collision_circle", "main.js")] 
      public partial Circle CollisionCircle();

      [JSImport("SplashKitBackendWASM.sprite_collision_kind", "main.js")] 
      public partial CollisionTestKind CollisionKind;

      [JSImport("SplashKitBackendWASM.sprite_collision_rectangle", "main.js")] 
      public partial Rectangle CollisionRectangle;

      [JSImport("SplashKitBackendWASM.sprite_current_cell", "main.js")] 
      public partial int CurrentCell;

      [JSImport("SplashKitBackendWASM.sprite_current_cell_rectangle", "main.js")] 
      public partial Rectangle CurrentCellRectangle;

      [JSImport("SplashKitBackendWASM.sprite_dx", "main.js")] 
      public partial double Dx;

      [JSImport("SplashKitBackendWASM.sprite_dy", "main.js")] 
      public partial double Dy;

      [JSImport("SplashKitBackendWASM.sprite_heading", "main.js")] 
      public partial float Heading;

      [JSImport("SplashKitBackendWASM.sprite_height", "main.js")] 
      public partial int Height;

      [JSImport("SplashKitBackendWASM.sprite_hide_layer", "main.js")] 
      public partial void HideLayer(string name);

      [JSImport("SplashKitBackendWASM.sprite_hide_layer", "main.js")] 
      public partial void HideLayer(int id);

      [JSImport("SplashKitBackendWASM.sprite_layer", "main.js")] 
      public partial Bitmap Layer(string name);

      [JSImport("SplashKitBackendWASM.sprite_layer", "main.js")] 
      public partial Bitmap Layer(int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_circle", "main.js")] 
      public partial Circle LayerCircle(string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_circle", "main.js")] 
      public partial Circle LayerCircle(int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_count", "main.js")] 
      public partial int LayerCount;

      [JSImport("SplashKitBackendWASM.sprite_layer_height", "main.js")] 
      public partial int LayerHeight(string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_height", "main.js")] 
      public partial int LayerHeight(int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_index", "main.js")] 
      public partial int IndexOfLayer(string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_name", "main.js")] 
      public partial string LayerName(int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_offset", "main.js")] 
      public partial Vector2D LayerOffset(string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_offset", "main.js")] 
      public partial Vector2D LayerOffset(int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_rectangle", "main.js")] 
      public partial Rectangle LayerRectangle(string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_rectangle", "main.js")] 
      public partial Rectangle LayerRectangle(int idx);

      [JSImport("SplashKitBackendWASM.sprite_layer_width", "main.js")] 
      public partial int LayerWidth(string name);

      [JSImport("SplashKitBackendWASM.sprite_layer_width", "main.js")] 
      public partial int LayerWidth(int idx);

      [JSImport("SplashKitBackendWASM.sprite_location_matrix", "main.js")] 
      public partial Matrix2D LocationMatrix;

      [JSImport("SplashKitBackendWASM.sprite_mass", "main.js")] 
      public partial float Mass;

      [JSImport("SplashKitBackendWASM.sprite_move_from_anchor_point", "main.js")] 
      public partial bool MoveFromAnchorPoint;

      [JSImport("SplashKitBackendWASM.sprite_move_to", "main.js")] 
      public partial void MoveTo(Point2D pt, float takingSeconds);

      [JSImport("SplashKitBackendWASM.sprite_name", "main.js")] 
      public partial string Name;

      [JSImport("SplashKitBackendWASM.sprite_offscreen", "main.js")] 
      public partial bool Offscreen();

      [JSImport("SplashKitBackendWASM.sprite_on_screen_at", "main.js")] 
      public partial bool OnScreenAt(Point2D pt);

      [JSImport("SplashKitBackendWASM.sprite_on_screen_at", "main.js")] 
      public partial bool OnScreenAt(double x, double y);

      [JSImport("SplashKitBackendWASM.sprite_position", "main.js")] 
      public partial Point2D Position;

      [JSImport("SplashKitBackendWASM.sprite_replay_animation", "main.js")] 
      public partial void ReplayAnimation();

      [JSImport("SplashKitBackendWASM.sprite_replay_animation", "main.js")] 
      public partial void ReplayAnimation(bool withSound);

      [JSImport("SplashKitBackendWASM.sprite_rotation", "main.js")] 
      public partial float Rotation;

      [JSImport("SplashKitBackendWASM.sprite_scale", "main.js")] 
      public partial float Scale;

      [JSImport("SplashKitBackendWASM.sprite_screen_rectangle", "main.js")] 
      public partial Rectangle ScreenRectangle;

      [JSImport("SplashKitBackendWASM.sprite_send_layer_backward", "main.js")] 
      public partial void SendLayerTobackward(int visibleLayer);

      [JSImport("SplashKitBackendWASM.sprite_send_layer_to_back", "main.js")] 
      public partial void SendLayerToBack(int visibleLayer);

      [JSImport("SplashKitBackendWASM.sprite_set_anchor_point", "main.js")] 
      public partial void AnchorPoint;

      [JSImport("SplashKitBackendWASM.sprite_set_collision_bitmap", "main.js")] 
      public partial void CollisionBitmap;

      [JSImport("SplashKitBackendWASM.sprite_set_collision_kind", "main.js")] 
      public partial void CollisionKind;

      [JSImport("SplashKitBackendWASM.sprite_set_dx", "main.js")] 
      public partial void Dx;

      [JSImport("SplashKitBackendWASM.sprite_set_dy", "main.js")] 
      public partial void Dy;

      [JSImport("SplashKitBackendWASM.sprite_set_heading", "main.js")] 
      public partial void Heading;

      [JSImport("SplashKitBackendWASM.sprite_set_layer_offset", "main.js")] 
      public partial void SetLayerOffset(string name, Vector2D value);

      [JSImport("SplashKitBackendWASM.sprite_set_layer_offset", "main.js")] 
      public partial void SetLayerOffset(int idx, Vector2D value);

      [JSImport("SplashKitBackendWASM.sprite_set_mass", "main.js")] 
      public partial void Mass;

      [JSImport("SplashKitBackendWASM.sprite_set_move_from_anchor_point", "main.js")] 
      public partial void MoveFromAnchorPoint;

      [JSImport("SplashKitBackendWASM.sprite_set_position", "main.js")] 
      public partial void Position;

      [JSImport("SplashKitBackendWASM.sprite_set_rotation", "main.js")] 
      public partial void Rotation;

      [JSImport("SplashKitBackendWASM.sprite_set_scale", "main.js")] 
      public partial void Scale;

      [JSImport("SplashKitBackendWASM.sprite_set_speed", "main.js")] 
      public partial void Speed;

      [JSImport("SplashKitBackendWASM.sprite_set_value", "main.js")] 
      public partial void SetValue(string name, float val);

      [JSImport("SplashKitBackendWASM.sprite_set_velocity", "main.js")] 
      public partial void Velocity;

      [JSImport("SplashKitBackendWASM.sprite_set_x", "main.js")] 
      public partial void X;

      [JSImport("SplashKitBackendWASM.sprite_set_y", "main.js")] 
      public partial void Y;

      [JSImport("SplashKitBackendWASM.sprite_show_layer", "main.js")] 
      public partial int ShowLayer(string name);

      [JSImport("SplashKitBackendWASM.sprite_show_layer", "main.js")] 
      public partial int ShowLayer(int id);

      [JSImport("SplashKitBackendWASM.sprite_speed", "main.js")] 
      public partial double Speed;

      [JSImport("SplashKitBackendWASM.sprite_start_animation", "main.js")] 
      public partial void StartAnimation(string named);

      [JSImport("SplashKitBackendWASM.sprite_start_animation", "main.js")] 
      public partial void StartAnimation(string named, bool withSound);

      [JSImport("SplashKitBackendWASM.sprite_start_animation", "main.js")] 
      public partial void StartAnimation(int idx);

      [JSImport("SplashKitBackendWASM.sprite_start_animation", "main.js")] 
      public partial void StartAnimation(int idx, bool withSound);

      [JSImport("SplashKitBackendWASM.sprite_stop_calling_on_event", "main.js")] 
      public partial void StopCallingOnEvent(SpriteEventHandler handler);

      [JSImport("SplashKitBackendWASM.sprite_toggle_layer_visible", "main.js")] 
      public partial void ToggleLayerVisible(string name);

      [JSImport("SplashKitBackendWASM.sprite_toggle_layer_visible", "main.js")] 
      public partial void ToggleLayerVisible(int id);

      [JSImport("SplashKitBackendWASM.sprite_value", "main.js")] 
      public partial float Value(string name);

      [JSImport("SplashKitBackendWASM.sprite_value_count", "main.js")] 
      public partial int ValueCount;

      [JSImport("SplashKitBackendWASM.sprite_velocity", "main.js")] 
      public partial Vector2D Velocity;

      [JSImport("SplashKitBackendWASM.sprite_visible_index_of_layer", "main.js")] 
      public partial int VisibleIndexOfLayer(string name);

      [JSImport("SplashKitBackendWASM.sprite_visible_index_of_layer", "main.js")] 
      public partial int VisibleIndexOfLayer(int id);

      [JSImport("SplashKitBackendWASM.sprite_visible_layer", "main.js")] 
      public partial int VisibleLayer(int idx);

      [JSImport("SplashKitBackendWASM.sprite_visible_layer_count", "main.js")] 
      public partial int VisibleLayerCount;

      [JSImport("SplashKitBackendWASM.sprite_visible_layer_id", "main.js")] 
      public partial int VisibleLayerIdAt(int idx);

      [JSImport("SplashKitBackendWASM.sprite_width", "main.js")] 
      public partial int Width;

      [JSImport("SplashKitBackendWASM.sprite_x", "main.js")] 
      public partial double X;

      [JSImport("SplashKitBackendWASM.sprite_y", "main.js")] 
      public partial double Y;

      [JSImport("SplashKitBackendWASM.update_sprite", "main.js")] 
      public partial void Update();

      [JSImport("SplashKitBackendWASM.update_sprite", "main.js")] 
      public partial void Update(bool withSound);

      [JSImport("SplashKitBackendWASM.update_sprite", "main.js")] 
      public partial void Update(float pct);

      [JSImport("SplashKitBackendWASM.update_sprite", "main.js")] 
      public partial void Update(float pct, bool withSound);

      [JSImport("SplashKitBackendWASM.update_sprite_animation", "main.js")] 
      public partial void UpdateAnimation();

      [JSImport("SplashKitBackendWASM.update_sprite_animation", "main.js")] 
      public partial void UpdateAnimation(bool withSound);

      [JSImport("SplashKitBackendWASM.update_sprite_animation", "main.js")] 
      public partial void UpdateAnimation(float pct);

      [JSImport("SplashKitBackendWASM.update_sprite_animation", "main.js")] 
      public partial void UpdateAnimation(float pct, bool withSound);

      [JSImport("SplashKitBackendWASM.vector_from_center_sprite_to_point", "main.js")] 
      public partial Vector2D VectorTo(Point2D pt);

      [JSImport("SplashKitBackendWASM.vector_from_to", "main.js")] 
      public partial Vector2D VectorTo(Sprite s2);

     } 

   public partial class AdcDevice
   {
      [JSImport("SplashKitBackendWASM.close_adc", "main.js")] 
      public partial void Close();

      [JSImport("SplashKitBackendWASM.read_adc", "main.js")] 
      public partial int Read(AdcPin channel);

     } 

   public partial class Timer
   {
      [JSImport("SplashKitBackendWASM.free_timer", "main.js")] 
      public partial void Free();

      [JSImport("SplashKitBackendWASM.pause_timer", "main.js")] 
      public partial void Pause();

      [JSImport("SplashKitBackendWASM.reset_timer", "main.js")] 
      public partial void Reset();

      [JSImport("SplashKitBackendWASM.resume_timer", "main.js")] 
      public partial void Resume();

      [JSImport("SplashKitBackendWASM.start_timer", "main.js")] 
      public partial void Start();

      [JSImport("SplashKitBackendWASM.stop_timer", "main.js")] 
      public partial void Stop();

      [JSImport("SplashKitBackendWASM.timer_paused", "main.js")] 
      public partial bool IsPaused;

      [JSImport("SplashKitBackendWASM.timer_started", "main.js")] 
      public partial bool IsStarted;

      [JSImport("SplashKitBackendWASM.timer_ticks", "main.js")] 
      public partial uint Ticks;

     } 


public struct Matrix2D {


       public double[] Elements;

}

public struct Circle {


       public Point2D Center;
       public double Radius;

      public void Draw(Color clr){
            SplashKit.Draw( clr,  this);
}
      public void Draw(Color clr, DrawingOptions opts){
            SplashKit.Draw( clr,  this,  opts);
}
      public void Fill(Color clr){
            SplashKit.Fill( clr,  this);
}
      public void Fill(Color clr, DrawingOptions opts){
            SplashKit.Fill( clr,  this,  opts);
}
}

public struct Color {


       public float R;
       public float G;
       public float B;
       public float A;

      public static Color HSBColor(double hue, double saturation, double brightness){
            SplashKit.HSB( hue,  saturation,  brightness);
}
      public static Color Random(){
            SplashKit.Random();
}
      public static Color RandomRGB(int alpha){
            SplashKit.RandomRGB( alpha);
}
      public static Color RGBColor(double red, double green, double blue){
            SplashKit.RGB( red,  green,  blue);
}
      public static Color RGBColor(int red, int green, int blue){
            SplashKit.RGB( red,  green,  blue);
}
      public static Color RGBAColor(double red, double green, double blue, double alpha){
            SplashKit.RGBA( red,  green,  blue,  alpha);
}
      public static Color RGBAColor(int red, int green, int blue, int alpha){
            SplashKit.RGBA( red,  green,  blue,  alpha);
}
}

public struct DrawingOptions {


       public void Dest;
       public float Scale_x;
       public float Scale_y;
       public float Angle;
       public float Anchor_offset_x;
       public float Anchor_offset_y;
       public bool Flip_x;
       public bool Flip_y;
       public bool Is_part;
       public Rectangle Part;
       public int Draw_cell;
       public drawing_dest Camera;
       public int Line_width;
       public animation Anim;

}

public struct Line {


       public Point2D Start_point;
       public Point2D End_point;

}

public struct Point2D {


       public double X;
       public double Y;

}

public struct Quad {


       public Point2D[] Points;

}

public struct Rectangle {


       public double X;
       public double Y;
       public double Width;
       public double Height;

}

public struct Triangle {


       public Point2D[] Points;

}

public struct Vector2D {


       public double X;
       public double Y;

}
public enum KeyCode{ 
UnknownKey = 0,
BackspaceKey = 8,
TabKey = 9,
ClearKey = 12,
ReturnKey = 13,
PauseKey = 19,
EscapeKey = 27,
SpaceKey = 32,
ExclaimKey = 33,
DoubleQuoteKey = 34,
HashKey = 35,
DollarKey = 36,
AmpersandKey = 38,
QuoteKey = 39,
LeftParenKey = 40,
RightParenKey = 41,
AsteriskKey = 42,
PlusKey = 43,
CommaKey = 44,
MinusKey = 45,
PeriodKey = 46,
SlashKey = 47,
Num0Key = 48,
Num1Key = 49,
Num2Key = 50,
Num3Key = 51,
Num4Key = 52,
Num5Key = 53,
Num6Key = 54,
Num7Key = 55,
Num8Key = 56,
Num9Key = 57,
ColonKey = 58,
SemiColonKey = 59,
LessKey = 60,
EqualsKey = 61,
GreaterKey = 62,
QuestionKey = 63,
AtKey = 64,
LeftBracketKey = 91,
BackslashKey = 92,
RightBracketKey = 93,
CaretKey = 94,
UnderscoreKey = 95,
BackquoteKey = 96,
AKey = 97,
BKey = 98,
CKey = 99,
DKey = 100,
EKey = 101,
FKey = 102,
GKey = 103,
HKey = 104,
IKey = 105,
JKey = 106,
KKey = 107,
LKey = 108,
MKey = 109,
NKey = 110,
OKey = 111,
PKey = 112,
QKey = 113,
RKey = 114,
SKey = 115,
TKey = 116,
UKey = 117,
VKey = 118,
WKey = 119,
XKey = 120,
YKey = 121,
ZKey = 122,
DeleteKey = 127,
Keypad0 = 256,
Keypad1 = 257,
Keypad2 = 258,
Keypad3 = 259,
Keypad4 = 260,
Keypad5 = 261,
Keypad6 = 262,
Keypad7 = 263,
Keypad8 = 264,
Keypad9 = 265,
KeypadPeriod = 266,
KeypadDivide = 267,
KeypadMultiply = 268,
KeypadMinus = 269,
KeypadPlus = 270,
KeypadEnter = 271,
KeypadEquals = 272,
UpKey = 273,
DownKey = 274,
RightKey = 275,
LeftKey = 276,
InsertKey = 277,
HomeKey = 278,
EndKey = 279,
PageUpKey = 280,
PageDownKey = 281,
F1Key = 282,
F2Key = 283,
F3Key = 284,
F4Key = 285,
F5Key = 286,
F6Key = 287,
F7Key = 288,
F8Key = 289,
F9Key = 290,
F10Key = 291,
F11Key = 292,
F12Key = 293,
F13Key = 294,
F14Key = 295,
F15Key = 296,
NumLockKey = 300,
CapsLockKey = 301,
ScrollLockKey = 302,
RightShiftKey = 303,
LeftShiftKey = 304,
RightCtrlKey = 305,
LeftCtrlKey = 306,
RightAltKey = 307,
LeftAltKey = 308,
LeftSuperKey = 311,
RightSuperKey = 312,
ModeKey = 313,
HelpKey = 315,
SysReqKey = 317,
MenuKey = 319,
PowerKey = 320,
}
public enum MouseButton{ 
NoButton = 0,
LeftButton = 0,
MiddleButton = 0,
RightButton = 0,
MouseX1Button = 0,
MouseX2Button = 0,
}
public enum LogLevel{ 
None = 0,
Info = 0,
Debug = 0,
Warning = 0,
Error = 0,
Fatal = 0,
}
public enum LogMode{ 
LogNone = 0,
LogConsole = 0,
LogFileOnly = 0,
LogConsoleAndFile = 0,
}
public enum ConnectionType{ 
TCP = 0,
UDP = 0,
Unknown = 0,
}
public enum HttpMethod{ 
HttpGetMethod = 0,
HttpPostMethod = 0,
HttpPutMethod = 0,
HttpDeleteMethod = 0,
HttpOptionsMethod = 0,
HttpTraceMethod = 0,
UnknownHttpMethod = 0,
}
public enum ResourceKind{ 
AnimationResource = 0,
BundleResource = 0,
FontResource = 0,
ImageResource = 0,
JsonResource = 0,
MusicResource = 0,
ServerResource = 0,
SoundResource = 0,
TimerResource = 0,
OtherResource = 0,
}
public enum CollisionTestKind{ 
PixelCollisions = 0,
AabbCollisions = 0,
}
public enum SpriteEventKind{ 
SpriteArrivedEvent = 0,
SpriteAnimationEndedEvent = 0,
SpriteTouchedEvent = 0,
SpriteClickedEvent = 0,
}
public enum AdcPin{ 
AdcPin0 = 0,
AdcPin1 = 1,
AdcPin2 = 2,
AdcPin3 = 3,
AdcPin4 = 4,
AdcPin5 = 5,
AdcPin6 = 6,
AdcPin7 = 7,
}
public enum AdcType{ 
Ads7830 = 0,
}
public enum DrawingDest{ 
DrawToScreen = 0,
DrawToWorld = 0,
DrawDefault = 0,
}
public enum FontStyle{ 
NormalFont = 0,
BoldFont = 1,
ItalicFont = 2,
UnderlineFont = 4,
}
public enum GpioPin{ 
Pin1 = 1,
Pin2 = 2,
Pin3 = 3,
Pin4 = 4,
Pin5 = 5,
Pin6 = 6,
Pin7 = 7,
Pin8 = 8,
Pin9 = 9,
Pin10 = 10,
Pin11 = 11,
Pin12 = 12,
Pin13 = 13,
Pin14 = 14,
Pin15 = 15,
Pin16 = 16,
Pin17 = 17,
Pin18 = 18,
Pin19 = 19,
Pin20 = 20,
Pin21 = 21,
Pin22 = 22,
Pin23 = 23,
Pin24 = 24,
Pin25 = 25,
Pin26 = 26,
Pin27 = 27,
Pin28 = 28,
Pin29 = 29,
Pin30 = 30,
Pin31 = 31,
Pin32 = 32,
Pin33 = 33,
Pin34 = 34,
Pin35 = 35,
Pin36 = 36,
Pin37 = 37,
Pin38 = 38,
Pin39 = 39,
Pin40 = 40,
}
public enum GpioPinMode{ 
GpioInput = 0,
GpioOutput = 1,
GpioAlt0 = 4,
GpioAlt1 = 5,
GpioAlt2 = 6,
GpioAlt3 = 7,
GpioAlt4 = 3,
GpioAlt5 = 2,
GpioDefaultMode = -1,
}
public enum GpioPinValue{ 
GpioDefaultValue = -1,
GpioLow = 0,
GpioHigh = 1,
}
public enum HttpStatusCode{ 
HttpStatusOk = 200,
HttpStatusCreated = 201,
HttpStatusNoContent = 204,
HttpStatusMovedPermanently = 301,
HttpStatusFound = 302,
HttpStatusSeeOther = 303,
HttpStatusBadRequest = 400,
HttpStatusUnauthorized = 401,
HttpStatusForbidden = 403,
HttpStatusNotFound = 404,
HttpStatusMethodNotAllowed = 405,
HttpStatusRequestTimeout = 408,
HttpStatusConflict = 409,
HttpStatusInternalServerError = 500,
HttpStatusNotImplemented = 501,
HttpStatusServiceUnavailable = 503,
}
public enum InterfaceStyle{ 
FlatDarkStyle = 0,
ShadedDarkStyle = 1,
FlatLightStyle = 2,
ShadedLightStyle = 3,
Bubble = 4,
BubbleMulticolored = 5,
}
public enum MotorDirection{ 
MotorForward = 0,
MotorBackward = 0,
}
public enum MotorDriverType{ 
L298n = 0,
}
public enum PullUpDown{ 
PudOff = 0,
PudDown = 1,
PudUp = 2,
}
} 
