using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Wapps.TOCrop
{
	// @interface TOActivityCroppedImageProvider : UIActivityItemProvider
	[BaseType (typeof(UIActivityItemProvider))]
	interface TOActivityCroppedImageProvider
	{
		// @property (readonly, nonatomic) UIImage * image;
		[Export ("image")]
		UIImage Image { get; }

		// @property (readonly, nonatomic) CGRect cropFrame;
		[Export ("cropFrame")]
		CGRect CropFrame { get; }

		// @property (readonly, nonatomic) NSInteger angle;
		[Export ("angle")]
		nint Angle { get; }

		// @property (readonly, nonatomic) BOOL circular;
		[Export ("circular")]
		bool Circular { get; }

		// -(instancetype)initWithImage:(UIImage *)image cropFrame:(CGRect)cropFrame angle:(NSInteger)angle circular:(BOOL)circular;
		[Export ("initWithImage:cropFrame:angle:circular:")]
		IntPtr Constructor (UIImage image, CGRect cropFrame, nint angle, bool circular);
	}

	// @interface TOCropOverlayView : UIView
	[BaseType (typeof(UIView))]
	interface TOCropOverlayView
	{
		// @property (assign, nonatomic) BOOL gridHidden;
		[Export ("gridHidden")]
		bool GridHidden { get; set; }

		// @property (assign, nonatomic) BOOL displayHorizontalGridLines;
		[Export ("displayHorizontalGridLines")]
		bool DisplayHorizontalGridLines { get; set; }

		// @property (assign, nonatomic) BOOL displayVerticalGridLines;
		[Export ("displayVerticalGridLines")]
		bool DisplayVerticalGridLines { get; set; }

		// -(void)setGridHidden:(BOOL)hidden animated:(BOOL)animated;
		[Export ("setGridHidden:animated:")]
		void SetGridHidden (bool hidden, bool animated);
	}

	// @interface TOCropScrollView : UIScrollView
	[BaseType (typeof(UIScrollView))]
	interface TOCropScrollView
	{
		// @property (copy, nonatomic) void (^touchesBegan)();
		[Export ("touchesBegan", ArgumentSemantic.Copy)]
		Action TouchesBegan { get; set; }

		// @property (copy, nonatomic) void (^touchesCancelled)();
		[Export ("touchesCancelled", ArgumentSemantic.Copy)]
		Action TouchesCancelled { get; set; }

		// @property (copy, nonatomic) void (^touchesEnded)();
		[Export ("touchesEnded", ArgumentSemantic.Copy)]
		Action TouchesEnded { get; set; }
	}

	// @interface TOCropToolbar : UIView
	[BaseType (typeof(UIView))]
	interface TOCropToolbar
	{
		// @property (assign, nonatomic) BOOL statusBarVisible;
		[Export ("statusBarVisible")]
		bool StatusBarVisible { get; set; }

		// @property (readonly, nonatomic, strong) UIButton * doneTextButton;
		[Export ("doneTextButton", ArgumentSemantic.Strong)]
		UIButton DoneTextButton { get; }

		// @property (readonly, nonatomic, strong) UIButton * doneIconButton;
		[Export ("doneIconButton", ArgumentSemantic.Strong)]
		UIButton DoneIconButton { get; }

		// @property (readonly, nonatomic, strong) UIButton * cancelTextButton;
		[Export ("cancelTextButton", ArgumentSemantic.Strong)]
		UIButton CancelTextButton { get; }

		// @property (readonly, nonatomic, strong) UIButton * cancelIconButton;
		[Export ("cancelIconButton", ArgumentSemantic.Strong)]
		UIButton CancelIconButton { get; }

		// @property (readonly, nonatomic, strong) UIButton * rotateCounterclockwiseButton;
		[Export ("rotateCounterclockwiseButton", ArgumentSemantic.Strong)]
		UIButton RotateCounterclockwiseButton { get; }

		// @property (readonly, nonatomic, strong) UIButton * resetButton;
		[Export ("resetButton", ArgumentSemantic.Strong)]
		UIButton ResetButton { get; }

		// @property (readonly, nonatomic, strong) UIButton * clampButton;
		[Export ("clampButton", ArgumentSemantic.Strong)]
		UIButton ClampButton { get; }

		// @property (readonly, nonatomic, strong) UIButton * rotateClockwiseButton;
		[Export ("rotateClockwiseButton", ArgumentSemantic.Strong)]
		UIButton RotateClockwiseButton { get; }

		// @property (readonly, nonatomic) UIButton * rotateButton;
		[Export ("rotateButton")]
		UIButton RotateButton { get; }

		// @property (copy, nonatomic) void (^cancelButtonTapped)();
		[Export ("cancelButtonTapped", ArgumentSemantic.Copy)]
		Action CancelButtonTapped { get; set; }

		// @property (copy, nonatomic) void (^doneButtonTapped)();
		[Export ("doneButtonTapped", ArgumentSemantic.Copy)]
		Action DoneButtonTapped { get; set; }

		// @property (copy, nonatomic) void (^rotateCounterclockwiseButtonTapped)();
		[Export ("rotateCounterclockwiseButtonTapped", ArgumentSemantic.Copy)]
		Action RotateCounterclockwiseButtonTapped { get; set; }

		// @property (copy, nonatomic) void (^rotateClockwiseButtonTapped)();
		[Export ("rotateClockwiseButtonTapped", ArgumentSemantic.Copy)]
		Action RotateClockwiseButtonTapped { get; set; }

		// @property (copy, nonatomic) void (^clampButtonTapped)();
		[Export ("clampButtonTapped", ArgumentSemantic.Copy)]
		Action ClampButtonTapped { get; set; }

		// @property (copy, nonatomic) void (^resetButtonTapped)();
		[Export ("resetButtonTapped", ArgumentSemantic.Copy)]
		Action ResetButtonTapped { get; set; }

		// @property (assign, nonatomic) BOOL clampButtonGlowing;
		[Export ("clampButtonGlowing")]
		bool ClampButtonGlowing { get; set; }

		// @property (readonly, nonatomic) CGRect clampButtonFrame;
		[Export ("clampButtonFrame")]
		CGRect ClampButtonFrame { get; }

		// @property (assign, nonatomic) BOOL clampButtonHidden;
		[Export ("clampButtonHidden")]
		bool ClampButtonHidden { get; set; }

		// @property (assign, nonatomic) BOOL rotateCounterclockwiseButtonHidden;
		[Export ("rotateCounterclockwiseButtonHidden")]
		bool RotateCounterclockwiseButtonHidden { get; set; }

		// @property (assign, nonatomic) BOOL rotateClockwiseButtonHidden;
		[Export ("rotateClockwiseButtonHidden")]
		bool RotateClockwiseButtonHidden { get; set; }

		// @property (assign, nonatomic) BOOL resetButtonEnabled;
		[Export ("resetButtonEnabled")]
		bool ResetButtonEnabled { get; set; }

		// @property (readonly, nonatomic) CGRect doneButtonFrame;
		[Export ("doneButtonFrame")]
		CGRect DoneButtonFrame { get; }
	}

	// @protocol TOCropViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface TOCropViewDelegate
	{
		// @required -(void)cropViewDidBecomeResettable:(TOCropView *)cropView;
		[Abstract]
		[Export ("cropViewDidBecomeResettable:")]
		void CropViewDidBecomeResettable (TOCropView cropView);

		// @required -(void)cropViewDidBecomeNonResettable:(TOCropView *)cropView;
		[Abstract]
		[Export ("cropViewDidBecomeNonResettable:")]
		void CropViewDidBecomeNonResettable (TOCropView cropView);
	}

	// @interface TOCropView : UIView
	[BaseType (typeof(UIView))]
	interface TOCropView
	{
		// @property (readonly, nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @property (readonly, assign, nonatomic) TOCropViewCroppingStyle croppingStyle;
		[Export ("croppingStyle", ArgumentSemantic.Assign)]
		TOCropViewCroppingStyle CroppingStyle { get; }

		// @property (readonly, nonatomic, strong) TOCropOverlayView * gridOverlayView;
		[Export ("gridOverlayView", ArgumentSemantic.Strong)]
		TOCropOverlayView GridOverlayView { get; }

		[Wrap ("WeakDelegate")]
		TOCropViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TOCropViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL cropBoxResizeEnabled;
		[Export ("cropBoxResizeEnabled")]
		bool CropBoxResizeEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL canBeReset;
		[Export ("canBeReset")]
		bool CanBeReset { get; }

		// @property (readonly, nonatomic) CGRect cropBoxFrame;
		[Export ("cropBoxFrame")]
		CGRect CropBoxFrame { get; }

		// @property (readonly, nonatomic) CGRect imageViewFrame;
		[Export ("imageViewFrame")]
		CGRect ImageViewFrame { get; }

		// @property (assign, nonatomic) UIEdgeInsets cropRegionInsets;
		[Export ("cropRegionInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets CropRegionInsets { get; set; }

		// @property (assign, nonatomic) BOOL simpleRenderMode;
		[Export ("simpleRenderMode")]
		bool SimpleRenderMode { get; set; }

		// @property (assign, nonatomic) CGSize aspectRatio;
		[Export ("aspectRatio", ArgumentSemantic.Assign)]
		CGSize AspectRatio { get; set; }

		// @property (assign, nonatomic) BOOL aspectRatioLockEnabled;
		[Export ("aspectRatioLockEnabled")]
		bool AspectRatioLockEnabled { get; set; }

		// @property (assign, nonatomic) BOOL resetAspectRatioEnabled;
		[Export ("resetAspectRatioEnabled")]
		bool ResetAspectRatioEnabled { get; set; }

		// @property (readonly, nonatomic) BOOL cropBoxAspectRatioIsPortrait;
		[Export ("cropBoxAspectRatioIsPortrait")]
		bool CropBoxAspectRatioIsPortrait { get; }

		// @property (readonly, assign, nonatomic) NSInteger angle;
		[Export ("angle")]
		nint Angle { get; }

		// @property (assign, nonatomic) BOOL croppingViewsHidden;
		[Export ("croppingViewsHidden")]
		bool CroppingViewsHidden { get; set; }

		// @property (assign, nonatomic) CGRect initialCroppedImageFrame;
		[Export ("initialCroppedImageFrame", ArgumentSemantic.Assign)]
		CGRect InitialCroppedImageFrame { get; set; }

		// @property (assign, nonatomic) NSInteger initialRotatedAngle;
		[Export ("initialRotatedAngle")]
		nint InitialRotatedAngle { get; set; }

		// @property (readonly, nonatomic) CGRect croppedImageFrame;
		[Export ("croppedImageFrame")]
		CGRect CroppedImageFrame { get; }

		// @property (assign, nonatomic) BOOL gridOverlayHidden;
		[Export ("gridOverlayHidden")]
		bool GridOverlayHidden { get; set; }

		// -(instancetype)initWithImage:(UIImage *)image;
		[Export ("initWithImage:")]
		IntPtr Constructor (UIImage image);

		// -(instancetype)initWithCroppingStyle:(TOCropViewCroppingStyle)style image:(UIImage *)image;
		[Export ("initWithCroppingStyle:image:")]
		IntPtr Constructor (TOCropViewCroppingStyle style, UIImage image);

		// -(void)setSimpleRenderMode:(BOOL)simpleMode animated:(BOOL)animated;
		[Export ("setSimpleRenderMode:animated:")]
		void SetSimpleRenderMode (bool simpleMode, bool animated);

		// -(void)prepareforRotation;
		[Export ("prepareforRotation")]
		void PrepareforRotation ();

		// -(void)performRelayoutForRotation;
		[Export ("performRelayoutForRotation")]
		void PerformRelayoutForRotation ();

		// -(void)resetLayoutToDefaultAnimated:(BOOL)animated;
		[Export ("resetLayoutToDefaultAnimated:")]
		void ResetLayoutToDefaultAnimated (bool animated);

		// -(void)setAspectRatio:(CGSize)aspectRatio animated:(BOOL)animated;
		[Export ("setAspectRatio:animated:")]
		void SetAspectRatio (CGSize aspectRatio, bool animated);

		// -(void)rotateImageNinetyDegreesAnimated:(BOOL)animated;
		[Export ("rotateImageNinetyDegreesAnimated:")]
		void RotateImageNinetyDegreesAnimated (bool animated);

		// -(void)rotateImageNinetyDegreesAnimated:(BOOL)animated clockwise:(BOOL)clockwise;
		[Export ("rotateImageNinetyDegreesAnimated:clockwise:")]
		void RotateImageNinetyDegreesAnimated (bool animated, bool clockwise);

		// -(void)setGridOverlayHidden:(BOOL)gridOverlayHidden animated:(BOOL)animated;
		[Export ("setGridOverlayHidden:animated:")]
		void SetGridOverlayHidden (bool gridOverlayHidden, bool animated);

		// -(void)setCroppingViewsHidden:(BOOL)hidden animated:(BOOL)animated;
		[Export ("setCroppingViewsHidden:animated:")]
		void SetCroppingViewsHidden (bool hidden, bool animated);

		// -(void)moveCroppedContentToCenterAnimated:(BOOL)animated;
		[Export ("moveCroppedContentToCenterAnimated:")]
		void MoveCroppedContentToCenterAnimated (bool animated);
	}

	// @protocol TOCropViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface TOCropViewControllerDelegate
	{
		// @optional -(void)cropViewController:(TOCropViewController *)cropViewController didCropImageToRect:(CGRect)cropRect angle:(NSInteger)angle;
		[Export ("cropViewController:didCropImageToRect:angle:")]
		void DidCropImageToRect (TOCropViewController cropViewController, CGRect cropRect, nint angle);

		// @optional -(void)cropViewController:(TOCropViewController *)cropViewController didCropToImage:(UIImage *)image withRect:(CGRect)cropRect angle:(NSInteger)angle;
		[Export ("cropViewController:didCropToImage:withRect:angle:")]
		void DidCropToImage (TOCropViewController cropViewController, UIImage image, CGRect cropRect, nint angle);

		// @optional -(void)cropViewController:(TOCropViewController *)cropViewController didCropToCircularImage:(UIImage *)image withRect:(CGRect)cropRect angle:(NSInteger)angle;
		[Export ("cropViewController:didCropToCircularImage:withRect:angle:")]
		void DidCropToCircularImage (TOCropViewController cropViewController, UIImage image, CGRect cropRect, nint angle);

		// @optional -(void)cropViewController:(TOCropViewController *)cropViewController didFinishCancelled:(BOOL)cancelled;
		[Export ("cropViewController:didFinishCancelled:")]
		void DidFinishCancelled (TOCropViewController cropViewController, bool cancelled);
	}

	// @interface TOCropViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface TOCropViewController
	{
		[Export("finalImage")]
		UIImage FinalImage { get; }

		// @property (readonly, nonatomic) UIImage * image;
		[Export ("image")]
		UIImage Image { get; }

		// @property (readonly, nonatomic) TOCropViewCroppingStyle croppingStyle;
		[Export ("croppingStyle")]
		TOCropViewCroppingStyle CroppingStyle { get; }

		// @property (readonly, nonatomic, strong) TOCropView * cropView;
		[Export ("cropView", ArgumentSemantic.Strong)]
		TOCropView CropView { get; }

		// @property (readonly, nonatomic, strong) TOCropToolbar * toolbar;
		[Export ("toolbar", ArgumentSemantic.Strong)]
		TOCropToolbar Toolbar { get; }

		[Wrap ("WeakDelegate")]
		TOCropViewControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TOCropViewControllerDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL showActivitySheetOnDone;
		[Export ("showActivitySheetOnDone")]
		bool ShowActivitySheetOnDone { get; set; }

		// @property (assign, nonatomic) TOCropViewControllerAspectRatioPreset aspectRatioPreset;
		[Export ("aspectRatioPreset", ArgumentSemantic.Assign)]
		TOCropViewControllerAspectRatioPreset AspectRatioPreset { get; set; }

		// @property (assign, nonatomic) CGSize customAspectRatio;
		[Export ("customAspectRatio", ArgumentSemantic.Assign)]
		CGSize CustomAspectRatio { get; set; }

		// @property (assign, nonatomic) BOOL aspectRatioLockEnabled;
		[Export ("aspectRatioLockEnabled")]
		bool AspectRatioLockEnabled { get; set; }

		// @property (assign, nonatomic) BOOL resetAspectRatioEnabled;
		[Export ("resetAspectRatioEnabled")]
		bool ResetAspectRatioEnabled { get; set; }

		// @property (assign, nonatomic) TOCropViewControllerToolbarPosition toolbarPosition;
		[Export ("toolbarPosition", ArgumentSemantic.Assign)]
		TOCropViewControllerToolbarPosition ToolbarPosition { get; set; }

		// @property (assign, nonatomic) BOOL rotateClockwiseButtonHidden;
		[Export ("rotateClockwiseButtonHidden")]
		bool RotateClockwiseButtonHidden { get; set; }

		// @property (assign, nonatomic) BOOL rotateButtonsHidden;
		[Export ("rotateButtonsHidden")]
		bool RotateButtonsHidden { get; set; }

		// @property (assign, nonatomic) BOOL aspectRatioPickerButtonHidden;
		[Export ("aspectRatioPickerButtonHidden")]
		bool AspectRatioPickerButtonHidden { get; set; }

		// @property (copy, nonatomic) void (^prepareForTransitionHandler)();
		[Export ("prepareForTransitionHandler", ArgumentSemantic.Copy)]
		Action PrepareForTransitionHandler { get; set; }

		// @property (nonatomic, strong) NSArray * activityItems;
		[Export ("activityItems", ArgumentSemantic.Strong)]
		NSObject[] ActivityItems { get; set; }

		// @property (nonatomic, strong) NSArray * applicationActivities;
		[Export ("applicationActivities", ArgumentSemantic.Strong)]
		NSObject[] ApplicationActivities { get; set; }

		// @property (nonatomic, strong) NSArray * excludedActivityTypes;
		[Export ("excludedActivityTypes", ArgumentSemantic.Strong)]
		NSObject[] ExcludedActivityTypes { get; set; }

		// -(instancetype)initWithImage:(UIImage *)image;
		[Export ("initWithImage:")]
		IntPtr Constructor (UIImage image);

		// -(instancetype)initWithCroppingStyle:(TOCropViewCroppingStyle)style image:(UIImage *)image;
		[Export ("initWithCroppingStyle:image:")]
		IntPtr Constructor (TOCropViewCroppingStyle style, UIImage image);

		// -(void)resetCropViewLayout;
		[Export ("resetCropViewLayout")]
		void ResetCropViewLayout ();

		// -(void)setAspectRatioPreset:(TOCropViewControllerAspectRatioPreset)aspectRatioPreset animated:(BOOL)animated;
		[Export ("setAspectRatioPreset:animated:")]
		void SetAspectRatioPreset (TOCropViewControllerAspectRatioPreset aspectRatioPreset, bool animated);

		// -(void)presentAnimatedFromParentViewController:(UIViewController *)viewController fromFrame:(CGRect)frame completion:(void (^)(void))completion;
		[Export ("presentAnimatedFromParentViewController:fromFrame:completion:")]
		void PresentAnimatedFromParentViewController (UIViewController viewController, CGRect frame, Action completion);

		// -(void)dismissAnimatedFromParentViewController:(UIViewController *)viewController withCroppedImage:(UIImage *)image toFrame:(CGRect)frame completion:(void (^)(void))completion;
		[Export ("dismissAnimatedFromParentViewController:withCroppedImage:toFrame:completion:")]
		void DismissAnimatedFromParentViewController (UIViewController viewController, UIImage image, CGRect frame, Action completion);

		// -(void)dismissAnimatedFromParentViewController:(UIViewController *)viewController toFrame:(CGRect)frame completion:(void (^)(void))completion;
		[Export ("dismissAnimatedFromParentViewController:toFrame:completion:")]
		void DismissAnimatedFromParentViewController (UIViewController viewController, CGRect frame, Action completion);
	}

	// @interface TOCropViewControllerTransitioning : NSObject <UIViewControllerAnimatedTransitioning>
	[BaseType (typeof(NSObject))]
	interface TOCropViewControllerTransitioning : IUIViewControllerAnimatedTransitioning
	{
		// @property (assign, nonatomic) BOOL isDismissing;
		[Export ("isDismissing")]
		bool IsDismissing { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (assign, nonatomic) CGRect fromFrame;
		[Export ("fromFrame", ArgumentSemantic.Assign)]
		CGRect FromFrame { get; set; }

		// @property (assign, nonatomic) CGRect toFrame;
		[Export ("toFrame", ArgumentSemantic.Assign)]
		CGRect ToFrame { get; set; }

		// @property (copy, nonatomic) void (^prepareForTransitionHandler)();
		[Export ("prepareForTransitionHandler", ArgumentSemantic.Copy)]
		Action PrepareForTransitionHandler { get; set; }

		// -(void)reset;
		[Export ("reset")]
		void Reset ();
	}

	// @interface TOCropp : NSObject
	[BaseType (typeof(NSObject))]
	interface TOCropp
	{
	}

	// @interface TOCroppedImageAttributes : NSObject
	[BaseType (typeof(NSObject))]
	interface TOCroppedImageAttributes
	{
		// @property (readonly, nonatomic) NSInteger angle;
		[Export ("angle")]
		nint Angle { get; }

		// @property (readonly, nonatomic) CGRect croppedFrame;
		[Export ("croppedFrame")]
		CGRect CroppedFrame { get; }

		// @property (readonly, nonatomic) CGSize originalImageSize;
		[Export ("originalImageSize")]
		CGSize OriginalImageSize { get; }

		// -(instancetype)initWithCroppedFrame:(CGRect)croppedFrame angle:(NSInteger)angle originalImageSize:(CGSize)originalSize;
		[Export ("initWithCroppedFrame:angle:originalImageSize:")]
		IntPtr Constructor (CGRect croppedFrame, nint angle, CGSize originalSize);
	}

	// @interface CropRotate (UIImage)
	[Category]
	[BaseType (typeof(UIImage))]
	interface UIImage_CropRotate
	{
		// -(UIImage *)croppedImageWithFrame:(CGRect)frame angle:(NSInteger)angle circularClip:(BOOL)circular;
		[Export ("croppedImageWithFrame:angle:circularClip:")]
		UIImage CroppedImageWithFrame (CGRect frame, nint angle, bool circular);
	}
}
