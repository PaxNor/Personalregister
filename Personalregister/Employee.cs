using System;

public class Employee
{
	string name;
	int salary;

	public Employee()
	{
		this.name = "undefined";
	}

	public Employee(string name, int salary)
	{
		this.name = name;
		this.salary = salary;
	}

	public void setName(string name) { this.name = name; }
	public void setSalary(int salary) { this.salary = salary; }
	public string getName() { return this.name; }
	public int getSalary() { return this.salary; }
}
