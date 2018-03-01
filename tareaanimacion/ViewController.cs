using System;
using UIKit;
using CoreAnimation;
using CoreGraphics;
using Foundation;

namespace tareaanimacion
{
	public partial class ViewController : UIViewController
	{
		
		CALayer CapaImagen3, capaImagen4, CapaImagen1;

		protected ViewController(IntPtr handle) : base(handle)
		{
		}
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.ViewDidLoad();

			#region "Capa Imagen 1"
			CapaImagen1 = new CALayer();
			CapaImagen1.Bounds = new CGRect(0, 0, 100, 100);
			CapaImagen1.Position = new CGPoint(50, 100);
			CapaImagen1.Contents = UIImage.FromFile
			("foto1.jpg").CGImage;
			CapaImagen1.ContentsGravity = CALayer.
			GravityResizeAspectFill;

			#region "Rotació Imagen 1"
			CapaImagen1.Transform = CATransform3D.
			MakeRotation((float)Math.PI * 2, 0, 0, 1);
			CAKeyFrameAnimation Rotacion1 =
			(CAKeyFrameAnimation)
			CAKeyFrameAnimation.FromKeyPath("transform");
			Rotacion1.Values = new NSObject[] {
					NSNumber.FromFloat (0f),
					NSNumber.FromFloat ((float)Math.PI / 2f),
					NSNumber.FromFloat ((float)Math.PI),
					NSNumber.FromFloat ((float)Math.PI * 2)};
			Rotacion1.ValueFunction = CAValueFunction.
			FromName(CAValueFunction.RotateZ);
			Rotacion1.Duration = 5;
			CapaImagen1.AddAnimation(Rotacion1, "transform");
			#endregion
			#endregion


			#region "Capa Imagen 3"
			CapaImagen3 = new CALayer();
			CapaImagen3.Bounds = new CGRect(0, 0, 100, 100);
			CapaImagen3.Position = new CGPoint(50, 500);
			CapaImagen3.Contents = UIImage.FromFile("foto1.jpg").CGImage;
			CapaImagen3.ContentsGravity = CALayer.GravityResizeAspectFill;

			#region "Animació Imagen 3"
			var OrigenImagen3 = CapaImagen3.Position;
			CapaImagen3.Position = new CGPoint(290, 100);
			var Animacion3 = CABasicAnimation.FromKeyPath("position");
			Animacion3.TimingFunction = CAMediaTimingFunction.FromName
			(CAMediaTimingFunction.EaseInEaseOut);
			Animacion3.From = NSValue.FromCGPoint(OrigenImagen3);
			Animacion3.To = NSValue.FromCGPoint(new CGPoint(290, 100));
			#endregion

			#region "Rotació Imagen 3"
			CapaImagen3.Transform = CATransform3D.
			MakeRotation((float)Math.PI * 2, 0, 0, 1);
			var Rotacion2 = (CAKeyFrameAnimation)
			CAKeyFrameAnimation.FromKeyPath("transform");
			Rotacion2.Values = new NSObject[] {
					NSNumber.FromFloat (0f),
					NSNumber.FromFloat ((float)Math.PI / 2f),
					NSNumber.FromFloat ((float)Math.PI),
					NSNumber.FromFloat ((float)Math.PI * 2)};
			Rotacion2.ValueFunction = CAValueFunction.FromName(CAValueFunction.RotateY);
			#endregion

			#region "Agregar Animació y Rotació a la Capa 3"
			var ConjuntodeAnimacion = CAAnimationGroup.CreateAnimation();
			ConjuntodeAnimacion.Duration = 2;
			ConjuntodeAnimacion.Animations = new CAAnimation[]
					{  Animacion3, Rotacion2 };
			CapaImagen3.AddAnimation(ConjuntodeAnimacion, null);
			#endregion
			#endregion

			//wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
			#region "Capa Imagen 4"
			capaImagen4 = new CALayer();
			capaImagen4.Bounds = new CGRect(0, 0, 100, 100);
			capaImagen4.Position = new CGPoint(300, 500);
			capaImagen4.Contents = UIImage.FromFile("foto1.jpg").CGImage;
			capaImagen4.ContentsGravity = CALayer.GravityResizeAspectFill;

			#region "Animació Imagen 4"
			var OrigenImagen4 = capaImagen4.Position;
			capaImagen4.Position = new CGPoint(38, 100);
			var Animacion4 = CABasicAnimation.FromKeyPath("position");
			Animacion4.TimingFunction = CAMediaTimingFunction.FromName
			(CAMediaTimingFunction.EaseInEaseOut);
			Animacion4.From = NSValue.FromCGPoint(OrigenImagen4);
			Animacion4.To = NSValue.FromCGPoint(new CGPoint(38, 100));
			#endregion

			#region "Rotació Imagen 3"
			capaImagen4.Transform = CATransform3D.
			MakeRotation((float)Math.PI * 2, 0, 0, 1);
			var Rotacion3 = (CAKeyFrameAnimation)
			CAKeyFrameAnimation.FromKeyPath("transform");
			Rotacion3.Values = new NSObject[] {
					NSNumber.FromFloat (0f),
					NSNumber.FromFloat ((float)Math.PI / 2f),
					NSNumber.FromFloat ((float)Math.PI),
					NSNumber.FromFloat ((float)Math.PI * 2)};
			Rotacion3.ValueFunction = CAValueFunction.FromName(CAValueFunction.RotateY);
			#endregion

			#region "Agregar Animació y Rotació a la Capa 3"
			var ConjuntodeAnimacion1 = CAAnimationGroup.CreateAnimation();
			ConjuntodeAnimacion1.Duration = 2;
			ConjuntodeAnimacion1.Animations = new CAAnimation[]
			{  Animacion4, Rotacion3 };
			capaImagen4.AddAnimation(ConjuntodeAnimacion1, null);
			#endregion
			#endregion


			View.Layer.AddSublayer(CapaImagen3);
			View.Layer.AddSublayer(capaImagen4);
		}
	}
}
