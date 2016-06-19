XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/TOCrop.xcodeproj
TARGET=TOCrop

all: libTOCropSDK.a

libTOCrop-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libTOCrop-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@
	
libTOCrop-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libTOCropSDK.a: libTOCrop-i386.a libTOCrop-armv7.a libTOCrop-arm64.a
	xcrun -sdk iphoneos lipo -create -output $@ $^

clean:
	-rm -f *.a *.dll