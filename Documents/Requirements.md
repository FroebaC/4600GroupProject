# Image Editor Project Requirements

## Team Memebers
Chris Froeba and Zach Travis

## Purpose
This project is going to be a utility that will be able to do basic image editing and will allow the user to process and combine images of type .jpg and .png.

## Requirements

1. **Name:** loadImage  
**Type:**  function  
**Summary:**  Will load an image from file onto the canvas.  

1. **Name:** displayImage  
**Type:** function  
**Summary:** Will display the image on the canvas.  
	
1. **Name:** drawOnImage  
**Type:** function  
**Summary:** Will allow drawing on the image with different pen widths.  

1. **Name:** penWidth  
**Type:** function  
**Summary:** Will allow the selection of different pen widths.  

1. **Name:** eraseFromImage  
**Type:** function  
**Summary:** Will allow the user to erase pixels from the image.  
	
1. **Name:** grayscaleImage  
**Type:** function  
**Summary:** Will convert the image to grayscale(black and white).  

1. **Name:** sepiaImage  
**Type:** function  
**Summary:** Will convert the image to sepia (brown and white).  

1. **Name:** scaleImage  
**Type:** funciton  
**Summary:** Will scale the image either up or down in width and length.  

1. **Name:** rotateImage  
**Type:** function  
**Summary:** Will allow the user to rotate the image around 360 degrees.  
	
1. **Name:** cropImage  
**Type:** function  
**Summary:** Will allow the user to take a selection of the picture, and will remove the rest.  

1. **Name:** layerImage  
**Type:** function  
**Summary:** Allows the user to layer multiple images over each other.  
	
1. **Name:** saveImage  
**Type:** function  
**Summary:** Allows the user to save the image.  

1. **Name:** platform_os  
**Type:** constraint  
**Summary:** The target platform operating system is Windows 10.  

1. **Name:** interfaceForRecentProjects  
**Type:** risk  
**Summary:** Will allow the user to select from recently edited images.  

1. **Name:** filpImage  
**Type:** function  
**Summary:** inverts the image from left to right or top to bottom.  
	
1. **Name:** autoColorCorrection  
**Type:** risk  
**Summary:** Will color correct the image automatically for the user.  

1. **Name:** paintBucket  
**Type:** function  
**Summary:** Will find pixels near eachother that are similar and will change them all to the same selected color.  
	
1. **Name:** paintBrush  
**Type:** function  
**Summary:** will allows the user to paint on the image with a seletable brush size.  

1. **Name:** brightnessCorrection  
**Type:** function  
**Summary:** Will automatically correct brigtness levels ins the image.  
	
1. **Name:** convertToBitmap  
**Type:** function  
**Summary:** To work with the images we should convert the image to bitmap to make working with them easier.  

1. **Name:** canvasToDisplay  
**Type:** function  
**Summary:** The WPF canvas will be used to display images.  
	
1. **Name:** fileTooLarge  
**Type:** constraint  
**Summary:** If the file is too large then it should be scaled down to something workable, this can reduce image quality.  

1. **Name:** sendToFront  
**Type:** function  
**Summary:** Allows layered image to be sent to the front of the layers.  
	
1. **Name:** sendToBack  
**Type:** function  
**Summary:** Allows layered image to be sent to the back of the layers.  

1. **Name:** colorPicker  
**Type:** function  
**Summary:** Allows for a color to be selected to be used with other drawing and painting functions.  

1. **Name:** fileType  
**Type:** constraint  
**Summary:** Will only accept .jpg and .png files.  

1. **Name:** Application_Environment  
**Type:** constraint  
**Summary:**  The application will require the .NET runtime environment on the machine.  
	
1. **Name:** brushSizeSelector  
**Type:** function  
**Summary:** Will allow the user to choose different brush sizes.  

1. **Name:** matrixManipulation  
**Type:** constraint  
**Summary:** .Net math libraries used for matrix manipulation.  

1. **Name:** interface_toolbar  
**Type:** function  
**Summary:** user interface element that allows ease of access to functions.  

1. **Name:** hotkeys  
**Type:** function  
**Summary:** Keys that can be pressed in succession to allow ease of access to functions.  

1. **Name:** interface_Layers  
**Type:** function  
**Summary:** interface to show the different layers and what the active layer is.  

1. **Name:** imageSelector  
**Type:** function  
**Summary:** Used to aid in image editing, will help convert images into bitmaps so they can be worked on.  

1. **Name:** undo  
**Type:** function  
**Summary:** Will allow the user to indo whatever action was their previous.  

1. **Name:** redo  
**Type:** function  
**Summary:** Will allow the user to redo the action was previously undone. Specifically will only be allowd if no other actions are taken between undo and redo.  
