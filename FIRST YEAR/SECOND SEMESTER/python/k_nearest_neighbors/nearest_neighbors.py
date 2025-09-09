from sklearn import datasets
from sklearn.neighbors import NearestNeighbors
from sklearn.preprocessing import StandardScaler


# Load data
iris = datasets.load_iris()

# features
features = iris.data

# standardize features
standardizer = StandardScaler()
features_standardized = standardizer.fit_transform(features)

# Create KNN model
nearest_neighbors = NearestNeighbors(
    n_neighbors=2,
    metric='manhattan').fit(features_standardized)

# Find the 2 nearest neighbors of a new observation
new_observation = [1, 1, 1, 1]

distances, indices = nearest_neighbors.kneighbors([new_observation])

print("Indices of the 2 nearest neighbors:", features_standardized[indices])
