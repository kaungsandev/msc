import pandas as pd
from sklearn.preprocessing import StandardScaler
from statistics import mean, median, mode
import matplotlib.pyplot as plt

# --- Data from the table ---
data = {
    'ID': ['EID001', 'EID002', 'EID003', 'EID004', 'EID005', 'EID006', 'EID007', 'EID008', 'EID009', 'EID010', 'EID011', 'EID012'],
    'Name': ['Aung Thiha', 'Kaung Myat', 'Win Myat Thu', 'Phoo Myat Sint', 'Lin Latt Kyal Sin', 'Su Latt Khin', 'Shin Moe Aye',
             'Arkar Kyaw', 'Hnin Nu Khin', 'Yu Ya Khin', 'Myat Bhone Kyaw', 'Htay Htay Khin'],
    'Department': ['Sales', 'Sales', 'Sales', 'Sales', 'Marketing', 'Marketing', 'Marketing', 'Marketing', 'HR', 'HR', 'Sales', 'Administration'],
    'Salary': [300000, 360000, 470000, 500000, 520000, 520000, 520000, 560000, 600000, 630000, 700000, 1100000]
}

df = pd.DataFrame(data)

# --- Standardize the salary ---
scaler = StandardScaler()
df['Salary_scaled'] = scaler.fit_transform(df[['Salary']]).ravel()
# df['Salary_scaled'] = df['Salary']  # try no standardization
mean_salary = mean(df['Salary_scaled'])
median_salary = median(df['Salary_scaled'])
try:
    mode_salary = mode(df['Salary_scaled'])  # may fail if no repeated values
except:
    mode_salary = "No mode (all unique values)"

print(f"Mean (standardized): {mean_salary:.2f}")
print(f"Median (standardized): {median_salary:.2f}")
print(f"Mode (standardized): {mode_salary}")

# --- Boxplot ---
plt.figure(figsize=(10, 4))
plt.boxplot(df['Salary_scaled'])
plt.title("Boxplot of Standardized Salaries")
plt.ylabel("Standardized Salary")
plt.show()

# --- Bar chart ---
plt.figure(figsize=(10, 4))
plt.bar(df['Name'], df['Salary_scaled'], color='skyblue')
plt.xticks(rotation=45)
plt.title("Bar Chart of Standardized Salaries")
plt.ylabel("Standardized Salary")
plt.show()

# --- Line graph ---
plt.figure(figsize=(10, 4))
plt.plot(df['Name'], df['Salary_scaled'],
         marker='o', linestyle='-', color='red')
plt.xticks(rotation=45)
plt.title("Line Graph of Standardized Salaries")
plt.ylabel("Standardized Salary")
plt.show()
