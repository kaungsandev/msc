import matplotlib.pyplot as plt
from statistics import mean, median, mode, stdev
import seaborn as s

scores = [55, 65, 65, 70, 72, 75, 80, 80, 85, 90, 92, 95, 100]

print("Scores:", scores)
print("Mean:", mean(scores))
print("Median:", median(scores))
print("Mode:", mode(scores))
print("Standard Deviation:", stdev(scores))

plt.boxplot(scores)

plt.title("Box Plot of Scores")
plt.ylabel("Scores")
plt.show()

plt.bar(range(len(scores)), scores, color='skyblue')
plt.show()

plt.plot(scores, marker='o', linestyle='-', color='orange')
plt.show()

plt.hist(scores, bins=10, color='lightgreen', edgecolor='black')
plt.show()
