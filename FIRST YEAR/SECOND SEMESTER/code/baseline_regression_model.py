from sklearn.linear_model import LinearRegression
from sklearn.datasets import load_wine
from sklearn.dummy import DummyRegressor
from sklearn.model_selection import train_test_split

# Load data
wine = load_wine()

# Create features
features, target = wine.data, wine.target

# Make test and training split
features_to_train, features_to_test, target_to_train, target_to_test = train_test_split(
    features, target, random_state=0
)

# Create a dummy regressior
dummy = DummyRegressor(strategy='mean')

# "Train" dummy regressor
dummy.fit(features_to_train, target_to_train)

# Get R-squared score
dummy_score = dummy.score(features_to_test, target_to_test)

print('Dummy model score:', dummy_score)
# Above code is creating some dummy regression model
# as baseline to test  or compare with our new model


ols = LinearRegression()
# Train the model
ols.fit(features_to_train, target_to_train)

new_model_score = ols.score(features_to_test, target_to_test)

print("New Model score:", new_model_score)
