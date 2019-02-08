#Image Editor Project Requirements

##Team Memebers
Chris and Zach

##Purpose
This project is going to be a utility that can be used to edit and process images.

##Requirements

	1.	*Name:*loadImage
		*Type:*function
		*Summary:*Will load an image from file onto the canvas

	2.	*Name:*displayImage
		*Type:*function
		*Summary:*Will display the image on the canvas
	
	3.	*Name:*drawOnImage
		*Type:*function
		*Summary:*Will allow drawing on the image in 1 pixel widths

	4.	*Name:*eraseFromImage
		*Type:*function
		*Summary:*Will allow the user to erase pixels from the image.
	
	5.	*Name:*grayscaleImage
		*Type:*function
		*Summary:*Will convert the image to grayscale(black and white).

	6.	*Name:*sepiaImage
		*Type:*function
		*Summary:*Will convert the image to sepia (brown and white).

	7.	*Name:*scaleImage
		*Type:*funciton
		*Summary:*Will scale the image either up or down in width and length.

	8.	*Name:*rotateImage
		*Type:*function
		*Summary:*Will allow the user to rotate the image around 360 degrees.
	
	9.	*Name:*cropImage
		*Type:*function
		*Summary:*Will allow the user to take a selection of the picture, and will remove the rest.

	10.	*Name:*layerImage
		*Type:*function
		*Summary:*Allows the user to layer multiple images over each other.
	
	11.	*Name:*saveImage
		*Type:*function
		*Summary:*Allows the user to save the image.

	12.	*Name:*platform_os
		*Type:*constraint
		*Summary:*The target platform operating system is Windows 10

	13.	*Name:*interfaceForRecentProjects
		*Type:*risk
		*Summary:*Will allow the user to select from recently edited images.

	14.	*Name:*filpImage
		*Type:*function
		*Summary:*inverts the image from left to right or top to bottom.
	
	15.	*Name:*autoColorCorrection
		*Type:*risk
		*Summary:*Will color correct the image automatically for the user

	16.	*Name:*paintBucket
		*Type:*function
		*Summary:*Will find pixels near eachother that are similar and will change them all to the same selected color
	
	16.	*Name:*paintBrush
		*Type:*function
		*Summary:*will allows the user to paint on the image with a seletable brush size

	17.	*Name:*brightnessCorrection
		*Type:*function
		*Summary:*Will automatically correct brigtness levels ins the image.
	
	18.	*Name:*convertToBitmap
		*Type:*risk
		*Summary:*To work with the images we should convert the image to bitmap to make working with them easier.

	19.	*Name:*canvasToDisplay
		*Type:*function
		*Summary:*The WPF canvas will be used to display images.
	
	20.	*Name:*fileTooLarge
		*Type:*constraint
		*Summary:*If the file is too large then it should be scaled down to something workable, this can reduce image quality

	21.	*Name:*sendToFront
		*Type:*function
		*Summary:*Allows layered image to be sent to the front of the layers.
	
	22.	*Name:*sendToBack
		*Type:*function
		*Summary:*Allows layered image to be sent to the back of the layers.

	23.	*Name:*colorPicker
		*Type:*function
		*Summary:*Allows for a color to be selected to be used with other drawing and painting functions

	24.	*Name:*fileType
		*Type:*constraint
		*Summary:*Will only accept .jpg and .png files

	25.	*Name:*Application_Environment
		*Type:*constraint
		*Summary:* The application will require the .NET runtime environment on the machine.
	
	26.	*Name:*brushSizeSelector
		*Type:*function
		*Summary:*Will allow the user to chose a brush size.