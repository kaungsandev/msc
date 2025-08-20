from sklearn.model_selection import cross_val_score
from sklearn.linear_model import LogisticRegression
from sklearn.datasets import make_classification

X, y = make_classification(n_samples=100000, n_features=3,
                           n_informative=3, n_redundant=0, n_classes=2, random_state=1)

logit = LogisticRegression()
# Cross-validate model using accuracy
scores = cross_val_score(logit, X, y, scoring="accuracy")

# Calculate the mean of the scores
mean_score = scores.mean()

print("Cross-validation scores:", scores)
print("Mean accuracy:", mean_score)

# Cross-validation scores
# The list of values: [0.9322, 0.933, 0.9359, 0.93375, 0.93705] are the individual accuracy scores from each fold of the cross-validation process.

# Here's a breakdown of what that means:

# Cross-validation: Instead of just splitting your data once into a single training set and a single test set, cross-validation is a more robust way to evaluate your model.

# K-Folds: In this case, sklearn likely used a default of 5-fold cross-validation. This means your entire dataset was randomly split into 5 equal-sized "folds" or subsets.

# Iteration: The process then runs 5 times (one for each fold):

# In the first iteration, the model is trained on 4 of the folds and tested on the 1st fold. The result is the first score: 0.9322.

# In the second iteration, the model is trained on the other 4 folds and tested on the 2nd fold. The result is the second score: 0.933.

# This continues until each of the 5 folds has been used as the test set exactly once.
