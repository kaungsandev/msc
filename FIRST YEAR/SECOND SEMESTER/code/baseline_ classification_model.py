from sklearn.ensemble import RandomForestClassifier
from sklearn.dummy import DummyClassifier
from sklearn.datasets import load_iris
from sklearn.model_selection import train_test_split

# Load data
iris = load_iris()

# Create target vector and feature matrix
features, target = iris.data, iris.target

# Split into training and test set
features_to_train, features_to_test, target_to_train, target_to_test = train_test_split(
    features, target, random_state=0
)

# Create a dummy classfier
dummy = DummyClassifier(strategy='uniform', random_state=1)

# Train the data
dummy.fit(features_to_train, target_to_train)

# get the score for testing
dummy_score = dummy.score(features_to_test, target_to_test)


classifier = RandomForestClassifier()

# Train model
classifier.fit(features_to_train, target_to_train)

# get the score for model
classifier_score = classifier.score(features_to_test, target_to_test)

print('Dummy score:', dummy_score)
print('Classifier score:', classifier_score)
