# Here is a simple question designed to be answered using a decision tree,
# with the expectation that the solution will involve
# splitting branches and showing node details.

# Question:

# A small tech startup wants to build a simple decision model
# to predict whether a customer will click on an ad for their new product.
# They have collected data from a pilot campaign
# on three customer attributes:

# Age: (25 or 40)
# Location: (Urban or Rural)
# Device Used: (Mobile or Desktop)

# Based on the small dataset below, construct a decision tree
# to predict whether a customer will click on the ad.

#  Customer	Age	Location	Device Used	Clicked?
# 1	         25	Urban	    Mobile	    Yes
# 2	         40	Rural	    Mobile	    No
# 3	         25	Urban	    Desktop	    No
# 4	         40	Urban	    Mobile	    Yes
# 5	         25	Rural	    Desktop	    No
# 6	         40	Urban	    Desktop	    Yes
# 7	         25	Urban	    Mobile	    Yes
# 8	         40	Rural	    Desktop	    No


# Use a decision tree classifier to train a model on this data.
# Plot the resulting decision tree.
# Ensure the plot clearly shows:

# The splitting conditions at each node(e.g., Age <= 32.5).

# The leaf nodes, which represent the final predicted outcome.

# The class counts within each node
# (how many "Yes" and "No" clicks are at that point).

# The final predicted class for each node


import matplotlib.pyplot as plt
from sklearn import tree
from sklearn.tree import DecisionTreeClassifier
import pandas as pd
from sklearn.preprocessing import LabelEncoder

# Create the dataset
data = {
    'Age': [25, 40, 25, 40, 25, 40, 25, 40],
    'Location': ['Urban', 'Rural', 'Urban', 'Urban', 'Rural', 'Urban', 'Urban', 'Rural'],
    'Device Used': ['Mobile', 'Mobile', 'Desktop', 'Mobile', 'Desktop', 'Desktop', 'Mobile', 'Desktop'],
    'Clicked': ['Yes', 'No', 'No', 'Yes', 'No', 'Yes', 'Yes', 'No']
}

df = pd.DataFrame(data)

# Convert categorical variables to numerical
le = LabelEncoder()
# Create a copy of the original dataframe for encoding
df_encoded = df.copy()

df_encoded['Age'] = le.fit_transform(df['Age'])
df_encoded['Location'] = le.fit_transform(df['Location'])
df_encoded['Device Used'] = le.fit_transform(df['Device Used'])
df_encoded['Clicked'] = le.fit_transform(df['Clicked'])

# Store the original class names for later us in the plot
class_names = ['No', 'Yes']  # 0 corresponds to 'No', 1 corresponds to 'Yes'
feature_names = ['Age', 'Location', 'Device Used']

# Define features and target variable
X = df_encoded[['Age', 'Location', 'Device Used']]  # Features
y = df_encoded['Clicked']  # Target variable

decision_tree = DecisionTreeClassifier()
model = decision_tree.fit(X, y)  # (features, target)

plt.figure(figsize=(12, 12))
tree.plot_tree(model,
               feature_names=feature_names,
               class_names=class_names,
               filled=True,         # Color the nodes based on the majority class
               rounded=True,        # Add rounded corners to the nodes
               proportion=True,     # Show the proportion of samples instead of counts
               impurity=False,      # Don't show the Gini impurity for a cleaner look
               fontsize=10)

plt.show()
