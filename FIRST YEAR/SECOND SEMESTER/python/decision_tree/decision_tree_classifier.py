from sklearn.tree import DecisionTreeClassifier
from sklearn import datasets
import matplotlib.pyplot as plt
from sklearn import tree


# Load data
iris = datasets.load_iris()
features = iris.data
target = iris.target

# Create Decision Tree classifer object
decisiontree = DecisionTreeClassifier(random_state=0)

# Train model
model = decisiontree.fit(features, target)


# Draw figure
plt.figure(figsize=(12, 12))
tree.plot_tree(decision_tree=model,
               feature_names=iris.feature_names,
               class_names=iris.target_names)

plt.show()

# Save figure as PNG
plt.savefig("decision_tree.png")
