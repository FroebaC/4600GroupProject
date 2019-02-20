# Image Editor Project Requirements

## Team Memebers
Chris Froeba and Zach Travis

## Purpose
This project is going to be a utility that will be able to do basic image editing and will allow the user to process and combine images of type .jpg and .png.

## Requirements

1. **Name:** Canvas  
**Type:** function  
**Summary:** A graphical canvas will provide a visual platform to position and display images. 

1. **Name:** image_Panel  
**Type:** function  
**Summary:** An image panel will show the user thumbnails of currently loaded images available for the session.

1. **Name:** load_Image  
**Type:**  function  
**Summary:**  Images may be loaded from local files to the program session.  

1. **Name:** save_Image  
**Type:** function  
**Summary:** The canvas may be saved to local files.  

1. **Name:** recent_Projects  
**Type:** function  
**Summary:** The program will save recently edited images for the user to load again.    

1. **Name:** select_Image  
**Type:** function  
**Summary:** Images available for the session may be selected for the user to perform operations, such as reposition or remove. 

1. **Name:** remove_Image  
**Type:** function  
**Summary:** Images may be removed from the session.

1. **Name:** interface_Toolbar  
**Type:** function  
**Summary:** An interactive toolbar element will display and allow access to various functions. 
	
1. **Name:** draw_Pen  
**Type:** function  
**Summary:** "Pens" are templates with fixed settings for drawing on the canvas, such as color and widths.  

1. **Name:** paint_Brush  
**Type:** function  
**Summary:** A "paint brush" will allow the user to layer color on the canvas with selectable sizes and color. 

1. **Name:** brush_Width  
**Type:** function  
**Summary:** The user can select different brush widths.  

1. **Name:** brush_Shape  
**Type:** function  
**Summary:** The user can select different brush shapes.  

1. **Name:** color_Picker  
**Type:** function  
**Summary:** Options for various colors are available for using the paint brush.  

1. **Name:** paint_Bucket  
**Type:** function  
**Summary:** Connected pixels that are very similar in color may be selected and changed using the "paint bucket".   

1. **Name:** erase_From_Image  
**Type:** function  
**Summary:** An "eraser" will allow the user to erase pixels from selected layers of images.  

1. **Name:** scale_Image  
**Type:** funciton  
**Summary:** Will scale the image either up or down in width and length.  

1. **Name:** rotate_Image  
**Type:** function  
**Summary:** Will allow the user to rotate the image by at least 45 degree increments, within 360 degrees.   

1. **Name:** flip_Image  
**Type:** function  
**Summary:** inverts the image from left to right or top to bottom.  
	
1. **Name:** crop_Image  
**Type:** function  
**Summary:** Will allow the user to take a selection of the picture, and will remove the rest.  

1. **Name:** layer_Image  
**Type:** function  
**Summary:** Allows the user to layer multiple images over each other.  

1. **Name:** grayscale_Image  
**Type:** function  
**Summary:** Will convert the image to grayscale(black and white).  

1. **Name:** sepia_Image  
**Type:** function  
**Summary:** Will convert the image to sepia (brown and white).  
	
1. **Name:** auto_Color_Correction  
**Type:** risk  
**Summary:** Will color correct the image automatically for the user.   

1. **Name:** brightness_Correction  
**Type:** function  
**Summary:** Will automatically correct brigtness levels ins the image.  

1. **Name:** interface_Layers  
**Type:** function  
**Summary:** interface to show the different layers and what the active layer is.  

1. **Name:** send_To_Front  
**Type:** function  
**Summary:** Allows layered image to be sent to the front of the layers.  
	
1. **Name:** send_To_Back  
**Type:** function  
**Summary:** Allows layered image to be sent to the back of the layers.  

1. **Name:** file_Type  
**Type:** constraint  
**Summary:** Will only accept .jpg and .png files.  
	
1. **Name:** convert_To_Bitmap  
**Type:** Constraint  
**Summary:** To work with the images we should convert the image to bitmap to make working with them easier.  

1. **Name:** image_Selector  
**Type:** function  
**Summary:** Used to aid in image editing, will help convert images into bitmaps so they can be worked on.  
	
1. **Name:** file_Too_Large  
**Type:** constraint  
**Summary:** If the file is too large then it should be scaled down to something workable, this can reduce image quality.  

1. **Name:** hotkeys  
**Type:** function  
**Summary:** Keys that can be pressed in succession to allow ease of access to functions.  

1. **Name:** undo_Action  
**Type:** function  
**Summary:** Will allow the user to indo whatever action was their previous.  

1. **Name:** redo_Action  
**Type:** function  
**Summary:** Will allow the user to redo the action was previously undone. Specifically will only be allowd if no other actions are taken between undo and redo.  

1. **Name:** platform_OS  
**Type:** constraint  
**Summary:** The target platform operating system is Windows 10.  

1. **Name:** application_Environment  
**Type:** constraint  
**Summary:**  The application will require the .NET runtime environment on the machine.  

1. **Name:** matrix_Manipulation  
**Type:** constraint  
**Summary:** .NET math libraries used for matrix manipulation.  
