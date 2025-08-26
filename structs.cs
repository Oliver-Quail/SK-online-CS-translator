
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
