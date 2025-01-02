
CREATE TABLE Project (
    project_id INT PRIMARY KEY,
    project_name VARCHAR(50) NOT NULL
);


CREATE TABLE Employee (
    employee_id INT PRIMARY KEY,
    employee_name VARCHAR(50) NOT NULL,
    project_id INT,
    FOREIGN KEY (project_id) REFERENCES Project(project_id)
);

INSERT INTO Project (project_id, project_name)
VALUES 
    (101, 'Project A'),
    (102, 'Project B'),
    (103, 'Project C');

INSERT INTO Employee (employee_id, employee_name, project_id)
VALUES 
    (1, 'Alice', 101),
    (2, 'Bob', 102),
    (3, 'Charlie', 101),
    (4, 'David', 103),
    (5, 'Eva', 102);


select
	p.project_name ,
    count(e.employee_id) as employee_count
from 
	project p
left join 
	employee e
on 
	p.project_id = e.project_id
group by 
	p.project_name
order by 
	p.project_name ASC

	
    
