# TOCropViewController for Xamarin.iOS

<p align="center">
<img src="https://github.com/TimOliver/TOCropViewController/blob/master/screenshot.jpg" width="890" style="margin:0 auto" />
</p>

Wapps.TOCrop is the Xamarin Binding version of <a href="https://github.com/TimOliver/TOCropViewController">TOCropViewController</a>

## Features
* Crop images by dragging the edges of a grid overlay.
* Optionally, crop circular copies of images.
* Rotate images in 90-degree segments.
* Clamp the crop box to a specific aspect ratio.
* A reset button to completely undo all changes.
* iOS 7/8 translucency to make it easier to view the cropped region.
* The choice of having the controller return the cropped image to a delegate, or immediately pass it to a `UIActivityViewController`.
* A custom animation and layout when the device is rotated to landscape mode.
* Custom 'opening' and 'dismissal' animations.
* Localized in 18 languages.

### Basic Implementation
```c#

void Button_TouchUpInside(object sender, EventArgs e)
{
	var cropVC = new TOCropViewController(TOCropViewCroppingStyle.Default, ImageView.Image);
	cropVC.Delegate = new CropVCDelegate (this);
	this.PresentViewController(cropVC, true, null);
}

class CropVCDelegate : TOCropViewControllerDelegate
{
	public override void DidCropImageToRect(TOCropViewController cropViewController, CGRect cropRect, nint angle)
	{
		cropViewController.PresentingViewController.DismissViewController(true, null);
		var myImage = cropViewController.FinalImage;
	}
}
```