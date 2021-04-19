﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winform_project
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Timekeeping")]
	public partial class TimekeepingDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertSchedule(Schedule instance);
    partial void UpdateSchedule(Schedule instance);
    partial void DeleteSchedule(Schedule instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    #endregion
		
		public TimekeepingDataContext() : 
				base(global::winform_project.Properties.Settings.Default.TimekeepingConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TimekeepingDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimekeepingDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimekeepingDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimekeepingDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Schedule> Schedules
		{
			get
			{
				return this.GetTable<Schedule>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Departments")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _department_id;
		
		private string _name;
		
		private string _description;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ondepartment_idChanging(int value);
    partial void Ondepartment_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public Department()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int department_id
		{
			get
			{
				return this._department_id;
			}
			set
			{
				if ((this._department_id != value))
				{
					this.Ondepartment_idChanging(value);
					this.SendPropertyChanging();
					this._department_id = value;
					this.SendPropertyChanged("department_id");
					this.Ondepartment_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(MAX)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Employees", ThisKey="department_id", OtherKey="department_id")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Schedules")]
	public partial class Schedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.DateTime _start_work_hour;
		
		private System.DateTime _end_work_hour;
		
		private System.Nullable<bool> _is_holiday;
		
		private System.Nullable<bool> _is_weekend;
		
		private System.Nullable<int> _employee_id;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onstart_work_hourChanging(System.DateTime value);
    partial void Onstart_work_hourChanged();
    partial void Onend_work_hourChanging(System.DateTime value);
    partial void Onend_work_hourChanged();
    partial void Onis_holidayChanging(System.Nullable<bool> value);
    partial void Onis_holidayChanged();
    partial void Onis_weekendChanging(System.Nullable<bool> value);
    partial void Onis_weekendChanged();
    partial void Onemployee_idChanging(System.Nullable<int> value);
    partial void Onemployee_idChanged();
    #endregion
		
		public Schedule()
		{
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_work_hour", DbType="DateTime NOT NULL")]
		public System.DateTime start_work_hour
		{
			get
			{
				return this._start_work_hour;
			}
			set
			{
				if ((this._start_work_hour != value))
				{
					this.Onstart_work_hourChanging(value);
					this.SendPropertyChanging();
					this._start_work_hour = value;
					this.SendPropertyChanged("start_work_hour");
					this.Onstart_work_hourChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_work_hour", DbType="DateTime NOT NULL")]
		public System.DateTime end_work_hour
		{
			get
			{
				return this._end_work_hour;
			}
			set
			{
				if ((this._end_work_hour != value))
				{
					this.Onend_work_hourChanging(value);
					this.SendPropertyChanging();
					this._end_work_hour = value;
					this.SendPropertyChanged("end_work_hour");
					this.Onend_work_hourChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_is_holiday", DbType="Bit")]
		public System.Nullable<bool> is_holiday
		{
			get
			{
				return this._is_holiday;
			}
			set
			{
				if ((this._is_holiday != value))
				{
					this.Onis_holidayChanging(value);
					this.SendPropertyChanging();
					this._is_holiday = value;
					this.SendPropertyChanged("is_holiday");
					this.Onis_holidayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_is_weekend", DbType="Bit")]
		public System.Nullable<bool> is_weekend
		{
			get
			{
				return this._is_weekend;
			}
			set
			{
				if ((this._is_weekend != value))
				{
					this.Onis_weekendChanging(value);
					this.SendPropertyChanging();
					this._is_weekend = value;
					this.SendPropertyChanged("is_weekend");
					this.Onis_weekendChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_id", DbType="Int")]
		public System.Nullable<int> employee_id
		{
			get
			{
				return this._employee_id;
			}
			set
			{
				if ((this._employee_id != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onemployee_idChanging(value);
					this.SendPropertyChanging();
					this._employee_id = value;
					this.SendPropertyChanged("employee_id");
					this.Onemployee_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Schedule", Storage="_Employee", ThisKey="employee_id", OtherKey="employee_id", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.Schedules.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.Schedules.Add(this);
						this._employee_id = value.employee_id;
					}
					else
					{
						this._employee_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Employee");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _employee_id;
		
		private string _name;
		
		private string _email;
		
		private string _phone;
		
		private string _password;
		
		private string _address;
		
		private System.DateTime _birthday;
		
		private bool _gender;
		
		private double _salary;
		
		private System.Nullable<int> _department_id;
		
		private EntitySet<Schedule> _Schedules;
		
		private EntityRef<Department> _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onemployee_idChanging(int value);
    partial void Onemployee_idChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnbirthdayChanging(System.DateTime value);
    partial void OnbirthdayChanged();
    partial void OngenderChanging(bool value);
    partial void OngenderChanged();
    partial void OnsalaryChanging(double value);
    partial void OnsalaryChanged();
    partial void Ondepartment_idChanging(System.Nullable<int> value);
    partial void Ondepartment_idChanged();
    #endregion
		
		public Employee()
		{
			this._Schedules = new EntitySet<Schedule>(new Action<Schedule>(this.attach_Schedules), new Action<Schedule>(this.detach_Schedules));
			this._Department = default(EntityRef<Department>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int employee_id
		{
			get
			{
				return this._employee_id;
			}
			set
			{
				if ((this._employee_id != value))
				{
					this.Onemployee_idChanging(value);
					this.SendPropertyChanging();
					this._employee_id = value;
					this.SendPropertyChanged("employee_id");
					this.Onemployee_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthday", DbType="Date NOT NULL")]
		public System.DateTime birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if ((this._birthday != value))
				{
					this.OnbirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("birthday");
					this.OnbirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="Bit NOT NULL")]
		public bool gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Float NOT NULL")]
		public double salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department_id", DbType="Int")]
		public System.Nullable<int> department_id
		{
			get
			{
				return this._department_id;
			}
			set
			{
				if ((this._department_id != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ondepartment_idChanging(value);
					this.SendPropertyChanging();
					this._department_id = value;
					this.SendPropertyChanged("department_id");
					this.Ondepartment_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Schedule", Storage="_Schedules", ThisKey="employee_id", OtherKey="employee_id")]
		public EntitySet<Schedule> Schedules
		{
			get
			{
				return this._Schedules;
			}
			set
			{
				this._Schedules.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Department", ThisKey="department_id", OtherKey="department_id", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._department_id = value.department_id;
					}
					else
					{
						this._department_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Department");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Schedules(Schedule entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_Schedules(Schedule entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
}
#pragma warning restore 1591
