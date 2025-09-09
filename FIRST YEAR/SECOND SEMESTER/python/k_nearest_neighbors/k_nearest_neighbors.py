from sklearn.neighbors import KNeighborsClassifier
from sklearn import datasets
from sklearn.preprocessing import StandardScaler

# Load data
iris = datasets.load_iris()
# features and target
features = iris.data
target = iris.target

# standardize features
standardizer = StandardScaler()
features_standardized = standardizer.fit_transform(features)

# Create KNN model
k_nearest_neighbors = KNeighborsClassifier(
    n_neighbors=5,
    n_jobs=-1).fit(features_standardized, target)

new_observations = [
    [0.75,  0.75,  0.75,  0.75],
    [1,  1,  1,  1]
]  # New data points to classify
# two dimensional array

predicted_class = k_nearest_neighbors.predict(new_observations)
# no need extra dimension []

print("Predicted class:", predicted_class)
