# A small online retail company wants to segment its customers
# to better tailor its marketing campaigns.
# They have a small, pilot dataset of 10 customers
# with two key attributes:

# Customer	Annual Income(k$)	Spending Score(1-100)
# 1     	        15	                39
# 2     	        21	                80
# 3     	        25	                18
# 4     	        35	                45
# 5     	        45	                58
# 6     	        55	                55
# 7     	        65	                40
# 8     	        70	                85
# 9     	        80	                30
# 10        	    88	                90
# Annual Income: (in thousands of dollars)

# Spending Score: (on a scale of 1 to 100, where 1 is low spending and 100 is high spending)

# The company believes there are three distinct groups of customers,
# and they want to use an algorithm to find these groups automatically.

from sklearn.cluster import KMeans
import matplotlib.pyplot as plt
import pandas as pd

# Define the dataset as a dictionary
# the main point is we only consider two features by questions
data = {
    'Income': [15, 21, 25, 35, 45, 55, 65, 70, 80, 88],
    'Spending Score': [39, 80, 18, 45, 58, 55, 40, 85, 30, 90]
}

dataframe = pd.DataFrame(data)

features = dataframe[['Income', 'Spending Score']]

# since we know there are three groups, we set n_clusters=3

kmean = KMeans(n_clusters=3, random_state=0)
kmean.fit(features)

plt.scatter(dataframe['Income'],
            dataframe['Spending Score'],
            c=kmean.labels_, marker='o')
plt.title('Customer Segmentation using K-Means Clustering (k=3)', fontsize=16)
plt.xlabel('Annual Income (k$)', fontsize=12)
plt.ylabel('Spending Score (1-100)', fontsize=12)
plt.show()


# if we don't know, we can use elbow method to find the optimal k
# we loop from 1 to 11 because we have 10 data points
inertias = []

for i in range(1, 11):
    kmeans = KMeans(n_clusters=i, random_state=0)
    kmeans.fit(features)
    inertias.append(kmeans.inertia_)

plt.plot(range(1, 11), inertias, marker='o')
plt.show()

# we can see the elbow point is at k=3 or k=4
# we can choose k=3 or k=4 based on the graph
