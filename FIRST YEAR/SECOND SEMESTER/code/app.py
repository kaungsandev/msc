import numpy as np

y_true = np.array([18, 15, 18, 16, 15, 14, 24])
y_prediction = np.array([0, 0, 0, 0, 0, 0, 0])

mse = np.mean((y_true-y_prediction) ** 2)
print("Mean Squared Error:", mse)
