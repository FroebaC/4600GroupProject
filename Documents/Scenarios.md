# Scenarios for ImgEdit

## Recolor Image with ImgEdit
**Initial Assumption:** The user has a local image of type .jpg or .png and want to reformat the color. They should have this image loaded into ImgEdit.  
**Normal:** The user should select the image. Once it has been selected, they may open a tab that presents them with options. At least two of the options, "Sepia" and "Greyscale" will scale the images color. Sepia will recolor the image to look more brown. Greyscale will adjust the colors to black, white or grey. After they choose an option, they should save their image to keep the changes.  
**What Can Go Wrong:** There is a possibility the image cannot recolor in a way the user wants or expected.  

## Image Cropping with ImgEdit
**Initial Assumption:** The user wishes to crop a photo that they have already saved on their computer. The user has to load photos that are saved to their device.  
**Normal:** They wish to crop something out of the image. The user opens up ImgEdit and then loads the picture they wish to crop. The image is loaded ont the canvas, and then the user selects the crop tool. The user can then select the portion of the image that they wish to keep, and will exclude the rest of the image. Once a selection is made the canvas will be reduced down to the area the user selected. This picture is now considered cropped, and the user can save their work.  
**What Can Go Wrong:** Once the user commits to erasing a portion of an image, they cannot always get it back. They should keep the original image saved as backup or use the undo feature before it is too late.  


## Layer with ImgEdit 
**Initial Assumption:** The user has multiple images they want to combine into one image. The user has loaded them already into the program.  
**Normal:** Since the user already has multiple images loaded to to ImgEdit, they should place them on the canvas. Once they are on the canvas, they can select and drag individual images to reorient them in relation to the canvas. They may also choose to place selected images in front of all of the others, or behind them. The user should save their work.  
**What Can Go Wrong:** Once the user has decided their work is complete, the composite image wll need to be flattened when it it saved. This can cause problems in that after the image is flattened the user will lose the ability to change any orientation that they would have been able to previously. They user should be notified of this before exiting the program.  
