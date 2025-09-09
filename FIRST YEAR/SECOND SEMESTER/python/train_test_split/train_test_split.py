import matplotlib.pyplot as plt
from sklearn.model_selection import train_test_split
from sklearn.datasets import make_classification
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import precision_score, recall_score, roc_curve, auc

# Create a synthetic dataset
# This dataset has 100 samples and 5 features, with 2 classes.
features, target = make_classification(
    n_samples=100,      # Number of samples
    n_features=5,       # Number of features
    n_informative=3,    # Number of informative features
    n_classes=2,        # Number of classes
    random_state=42     # Set random state for reproducibility
)

# Split the dataset into training and testing sets
# 10% of the data will be used for testing the model.
features_for_train, features_for_test, target_for_train, target_for_test = train_test_split(
    features,
    target,
    test_size=0.1,      # 10% of the data for testing
    random_state=3)

# Initialize and train the Logistic Regression model
# Logistic Regression is a good choice for binary classification.
logit = LogisticRegression()
logit.fit(features_for_train, target_for_train)

# Make predictions on the test data
# We need to make predictions to calculate precision and recall.
target_predicted = logit.predict(features_for_test)

# Get the probability estimates for the ROC curve
# The roc_curve function needs the probability of the positive class (class 1).
# For example, for a single sample, it might return [0.2, 0.8],
# meaning there is a 20 % chance it belongs to class 0 and an 80 % chance it belongs to class 1.
# [:, 1]: This is NumPy slicing syntax.
# It selects all rows (:) and only the second column (1).
# Since the predict_proba output has the probability of the positive class (class 1) in the second column
y_scores = logit.predict_proba(features_for_test)[:, 1]

# Print the standard test set score (accuracy)
# Here is a breakdown of what each part means:

# {}: This is a placeholder for a variable or value.
# :  This introduces the format specification.
# .2f This is the actual formatting code.

# . A decimal point.
# 2 The number of digits to display after the decimal point.
# f Indicates that the number should be formatted as a floating-point number(a number with a decimal).
print("Test set accuracy: {:.2f}".format(
    logit.score(features_for_test, target_for_test)))

# Calculate and print precision
# Precision is the ratio of true positive predictions to the total positive predictions.
precision = precision_score(target_for_test, target_predicted)
print("Precision: {:.2f}".format(precision))

# Calculate and print recall
# Recall is the ratio of true positive predictions to the total number of actual positives.
recall = recall_score(target_for_test, target_predicted)
print("Recall: {:.2f}".format(recall))

# Calculate ROC curve and AUC score
# fpr = False Positive Rate, tpr = True Positive Rate
fpr, tpr, thresholds = roc_curve(target_for_test, y_scores)
roc_auc = auc(fpr, tpr)
print("AUC Score: {:.2f}".format(roc_auc))

# Plot the ROC curve using Matplotlib
plt.figure(figsize=(8, 6))
plt.plot(fpr, tpr, color='blue', lw=2,
         label='ROC curve (area = %0.2f)' % roc_auc)
plt.plot([0, 1], [0, 1], color='gray', lw=2,
         linestyle='--', label='Random Classifier')
plt.xlim([0.0, 1.0])
plt.ylim([0.0, 1.05])
plt.xlabel('False Positive Rate (FPR)', fontsize=12)
plt.ylabel('True Positive Rate (TPR)', fontsize=12)
plt.title('Receiver Operating Characteristic (ROC) Curve', fontsize=14)
plt.legend(loc="lower right")
plt.grid(True)
plt.tight_layout()

# Save the plot
plt.savefig('roc_curve.png', dpi=300)

# Show the plot
plt.show()
