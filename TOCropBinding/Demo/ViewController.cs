using System;
using CoreGraphics;
using UIKit;
using Wapps.TOCrop;

namespace Demo
{
	public partial class ViewController : UIViewController
	{
		UIImageView ImageView { get; set; }

		UIButton BtnEdit { get; set; }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			this.View.BackgroundColor = UIColor.White;

			ImageView = new UIImageView (UIImage.FromFile("image.png"));
			ImageView.ContentMode = UIViewContentMode.ScaleAspectFit;
			this.View.AddSubview(ImageView);

			BtnEdit = new UIButton();
			BtnEdit.SetTitle("Start demo", UIControlState.Normal);
			BtnEdit.TouchUpInside += Button_TouchUpInside;
			BtnEdit.BackgroundColor = UIColor.Red;
			this.View.AddSubview(BtnEdit);
		}

		public override void ViewWillLayoutSubviews()
		{
			base.ViewWillLayoutSubviews();
			this.ImageView.Frame = this.View.Bounds;
			this.BtnEdit.Frame = new CGRect(80, 30, 100, 30);
		}

		void Button_TouchUpInside(object sender, EventArgs e)
		{
			var cropVC = new TOCropViewController(TOCropViewCroppingStyle.Default, ImageView.Image);
			cropVC.Delegate = new CropVCDelegate (this);
			this.PresentViewController(cropVC, true, null);
		}

		class CropVCDelegate : TOCropViewControllerDelegate
		{
			WeakReference<ViewController> _owner;

			public CropVCDelegate(ViewController owner)
			{
				_owner = new WeakReference<ViewController>(owner);
			}

			public override void DidCropImageToRect(TOCropViewController cropViewController, CGRect cropRect, nint angle)
			{
				cropViewController.PresentingViewController.DismissViewController(true, null);

				ViewController owner;
				if (_owner.TryGetTarget(out owner))
				{
					owner.ImageView.Image = cropViewController.FinalImage;
				}
			}
		}

	}
}

