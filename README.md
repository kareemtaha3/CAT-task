
# To-Do List API and Problem Solving Challenges

This repository contains a web API built using **.NET Framework** to manage a to-do list, as well as solutions to coding challenges in **C++** and **SQL**.

## ⚙️ Requirements

### **1. Web API for Managing a To-Do List**

I built a simple API with the following routes:

- **POST `/todos`**: Add a new to-do item. Fields: `title` (string) and `status` (default `status` = "pending") and `due date`(datatime).
- **GET `/todos`**: Retrieve all to-do items.
- **GET `/todos\:id`**: retieve one item by id.
- **PUT `/todos/:id`**: Update the `status` of a to-do item to either `completed` or `pending`.
- **DELETE `/todos/:id`**: Delete a to-do item by its ID.

#### Technologies Used:
- **Backend Framework**: .NET Framework
- **Database**: Microsoft sql server

#### How to Use:
1. Clone this repository:
   ```bash
   git clone https://github.com/kareemtaha3/repository.git
   ```
2. Navigate to the project folder:
   ```bash
   cd repository
   ```
3. Set up and configure your database (if needed).
4. Run the API using Visual Studio or the .NET CLI.

### **2. Coding Challenges**

#### Challenge 1: Search in a Sorted Array (C++)

**Problem**:
Given an array of integers `nums` sorted in ascending order, and an integer `target`, write a function to search for `target` in `nums`. Return its index if found, otherwise return `-1`.

**Example Input**:
```cpp
nums = [-1, 0, 3, 5, 9, 12], target = 9
```

**Example Output**:
```cpp
4
```

The target value `9` is located at index 4 in the array.

You can find the solution in the `cpp` folder of this repository.

#### Challenge 2: SQL Query for Employee Count per Project

**Problem**:
You are working with a database that stores information about employees and their project assignments. Write an SQL query to retrieve the `project_name` and the number of employees assigned to each project, ordered by `project_name`.

**SQL Solution**:
```sql
SELECT p.project_name, COUNT(e.employee_id) AS employee_count
FROM Project p
JOIN Employee e ON p.project_id = e.project_id
GROUP BY p.project_name
ORDER BY p.project_name;
```

#### Example Output:

| project_name | employee_count |
| --- | --- |
| Project A | 2 |
| Project B | 2 |
| Project C | 1 |

### **3. How to Run the Project**

#### .NET API:

1. Clone the repository:
   ```bash
   git clone https://github.com/kareemtaha3/repository.git
   ```
2. Open the project in Visual Studio.
3. Run the application via **F5** or the **.NET CLI**.

#### C++ Solution:
1. Clone the repository.
2. Compile the C++ code:
   ```bash
   g++ ps.cpp -o ps
   ```
3. Run the compiled program:
   ```bash
   ./ps
   ```

#### SQL Query:
1. Set up the **Employee** and **Project** tables in your MySQL database.
2. Run the SQL query above to get the employee count for each project.

---

## 🛠️ Technologies Used

- **Backend Framework**: .NET Framework
- **Database**: Microsoft sql server
- **Programming Languages**: C++, SQL
- **Version Control**: Git, GitHub

## 🤝 Contributing

Feel free to fork this repository, make changes, and submit a pull request. If you find any issues or want to improve the project, don't hesitate to contribute.

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```
