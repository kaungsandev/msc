from sklearn.cluster import KMeans
import matplotlib.pyplot as plt

x = [1, 2, 3, 4, 5]
y = [2, 3, 5, 7, 11]

# Create a scatter plot simple example of initial data points
plt.scatter(x, y, marker='o')
plt.show()


data = list(zip(x, y))
print(data)

inertias = []

for i in range(1, 6):
    # Initialize KMeans with i clusters
    kmeans = KMeans(n_clusters=i, random_state=0)
    kmeans.fit(data)  # Fit the model to the data
    inertias.append(kmeans.inertia_)  # Append the inertia to the list

plt.plot(range(1, 6), inertias, marker='o')
plt.title('Elbow Method for Optimal k')
plt.xlabel('Number of clusters (k)')
plt.ylabel('Inertia')
plt.show()

# from the elbow graph, we choose k=3 or k=2 depending on the figure,
# the point where inertia/curve starts to decrease more slowly

kmeans = KMeans(n_clusters=3, random_state=0)
kmeans.fit(data)

plt.scatter(x, y, c=kmeans.labels_, marker='o')
plt.show()
