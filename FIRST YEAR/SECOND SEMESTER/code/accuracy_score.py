from sklearn.model_selection import train_test_split
from sklearn.metrics import accuracy_score
from sklearn.linear_model import LogisticRegression
from sklearn.datasets import make_classification

X,y = make_classification(n_samples=100000, n_features= 3, n_informative=3, n_redundant=0, n_classes=2, random_state=1)

logit= LogisticRegression()
# Create training and test split
X_train, X_test, y_train, y_test = train_test_split(X,
y,
test_size=0.1,
random_state=1)
# Predict values for training target vector
y_hat = logit.fit(X_train, y_train).predict(X_test)
# Calculate accuracy
score = accuracy_score(y_test, y_hat)
print ("Accuracy score:", score )
