# for 10 randomly selected adults,
# draw a boxplot, scatterplot, and barchart
# sample data
# age = [23, 45, 31, 35, 40, 29, 50, 38, 41, 33]
# fat = [15, 20, 18, 22, 25, 17, 30, 21, 24, 19]

import pandas as pd
import matplotlib.pyplot as plt

data = {
    'age': [23, 45, 31, 35, 40, 29, 50, 38, 41, 33],
    'fat': [15, 20, 18, 22, 25, 17, 30, 21, 24, 19]
}

dataframe = pd.DataFrame(data)

# boxplot

plt.boxplot(dataframe['age'])
plt.show()

# scatterplot
plt.scatter(dataframe['age'], dataframe['fat'], color='blue')
plt.xlabel('Age')
plt.ylabel('Fat')
plt.show()

# barchart
dataframe.plot(kind='bar', y=['age', 'fat'], color=['orange', 'green'])
plt.show()

dataframe.plot(kind='box', x='age', y='fat')
plt.show()
