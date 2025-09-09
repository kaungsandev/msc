from sklearn.datasets import load_iris
from sklearn.decomposition import PCA
from sklearn.preprocessing import scale

import matplotlib.pyplot as plt
import numpy as np

boston = load_iris()

features, target = boston.data, boston.target
pca = PCA().fit(scale(features))

C = pca.transform(scale(features))

plt.scatter(C[:, 0], C[:, 1], s=30, )
plt.grid()
plt.xlabel('First principal component')
plt.ylabel('Second principal component')
plt.show()
