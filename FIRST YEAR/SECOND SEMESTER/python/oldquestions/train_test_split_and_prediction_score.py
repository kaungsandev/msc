# Use a built-in dataset
# to demonstrate splitting between train set and the test set
# Use prediction score to predict the accuracy.
# Use any data visualization to carray out data exploratory stage.

from sklearn.datasets import load_iris
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import accuracy_score
from matplotlib import pyplot as plt

iris = load_iris()

features = iris.data
target = iris.target

features_for_train, features_for_test, target_for_train, target_for_test = train_test_split(
    features,
    target,
    test_size=0.2,
    random_state=0)

model = LogisticRegression()
model.fit(features_for_train, target_for_train)


model_predictions = model.predict(features_for_test)

accuracy = accuracy_score(target_for_test, model_predictions)
print(f"Accuracy: {accuracy}")

# Data visualization
plt.scatter(features[:, 0], features[:, 1], c=target, cmap='viridis')
plt.xlabel(iris.feature_names[0])
plt.ylabel(iris.feature_names[1])
plt.title("Iris Dataset Visualization")
plt.show()
