from skimage.io import imread
from skimage import filters
from skimage.color import rgb2gray
from skimage.transform import resize
import matplotlib.pyplot as plt
import matplotlib.cm as cm

exampleimage = imread("./unstructured_image/cat.jpg")

grayimage = rgb2gray(exampleimage)
plt.imshow(grayimage, cmap=cm.gray)
plt.show()


median_filter = filters.median(grayimage)
plt.imshow(median_filter, cmap=cm.gray)
plt.show()

median_filter = filters.gaussian(grayimage)
plt.imshow(median_filter, cmap=cm.gray)
plt.show()
