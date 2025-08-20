from sklearn import datasets
from sklearn import metrics
from sklearn.model_selection import KFold, cross_val_score
from sklearn.pipeline import make_pipeline
from sklearn.linear_model import LogisticRegression
from sklearn.preprocessing import StandardScaler

# Load digit dataset
digits = datasets.load_digits()

# Create feature matrix
features = digits.data

# Create target vector
target = digits.target

# Create standardizer
standardizer = StandardScaler()

# Create logistic regression object
logit = LogisticRegression()

# Create a pipline that standardizes, then runs logistic regression
pipline = make_pipeline(standardizer, logit)

# Create k-fold cross-validation
kf = KFold(n_splits=5, shuffle=True, random_state=0)

# Conduct k-fold cross-validation
cv_results = cross_val_score(
    pipline, features, target, cv=kf, scoring="accuracy", n_jobs=-1)

print("Cross-Validation score: ", cv_results)
print("Mean", cv_results.mean())
