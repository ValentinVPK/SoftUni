
**Exercises: Triggers and Transactions** 

1. **Create Table Logs** 

Create a table – **Logs** (LogId, AccountId, OldSum, NewSum). Add a **trigger** to the Accounts table that **enters** a new entry into the **Logs** table every time the sum **on** an **account** **change**. Submit **only** the **query** that **creates** the **trigger**. 

**Example** 



|**LogId** |**AccountId** |**OldSum** |**NewSum** |
| - | - | - | - |
|1 |1 |123.12 |113.12 |
|… |… |… |… |
2. **Create Table Emails** 

Create another table – **NotificationEmails**(Id, Recipient, Subject, Body). Add a **trigger** to logs table and **create new email whenever new record is inserted in logs table.** The following data is required to be filled for each email: 

- **Recipient** – AccountId 
- **Subject** – "Balance change for account: **{AccountId}**" 
- **Body** - "On **{date}** your balance was changed from **{old}** to **{new}.**" 

**Submit** your query **only** for the **trigger** action. 

**Example** 



|**Id** |**Recipient** |**Subject** |**Body** |
| - | - | - | - |
|1 |1 |Balance change for account: 1 |On Sep 12 2016 2:09PM your balance was changed from 113.12 to 103.12. |
|… |… |… |… |
3. **Deposit Money** 

Add stored procedure **usp\_DepositMoney** (**AccountId**, **MoneyAmount**) that deposits money to an existing account. Make sure to guarantee valid positive **MoneyAmount** with precision up to **fourth sign after decimal point**. The procedure should produce exact results working with the specified precision. 

**Example** 

Here is the result for **AccountId = 1** and **MoneyAmount = 10.** 



|**AccountId** |**AccountHolderId** |**Balance** |
| - | - | - |
|1 |1 |133.1200 |
4. **Withdraw Money** 

Add stored procedure **usp\_WithdrawMoney** (**AccountId**, **MoneyAmount**) that withdraws money from an existing account. Make sure to guarantee valid positive **MoneyAmount** with precision up to **fourth sign after decimal point**. The procedure should produce exact results working with the specified precision. 

**Example** 

Here is the result for **AccountId = 5** and **MoneyAmount = 25.** 

|**AccountId** |**AccountHolderId** |**Balance** |
| - | - | - |
|5 |11 |36496.2000 |
5. **Money Transfer** 

Create stored procedure **usp\_TransferMoney**(SenderId, ReceiverId, Amount) that **transfers money from one account to another**. Make sure to guarantee valid positive MoneyAmount with precision up to **the fourth sign after the decimal point**. Make sure that the whole procedure **passes without errors** and **if an error occurs make** **no change in the database.** You can use both: "**usp\_DepositMoney**", "**usp\_WithdrawMoney**" (look at the previous two problems about those procedures).  

**Example** 

Here is the result for **SenderId = 5, ReceiverId = 1** and **MoneyAmount = 5000.** 



|**AccountId** |**AccountHolderId** |**Balance** |
| - | - | - |
|1 |1 |5123.12 |
|5 |11 |31521.2000 |
**Queries for SoftUni Database** 

6. **Employees with Three Projects** 

Create a procedure **usp\_AssignProject(@emloyeeId, @projectID)** that **assigns** **projects** to employee. If the employee has more than **3** project throw **exception** and **rollback** the changes. The exception message must be: "**The employee has too many projects!**" with Severity = 16, State = 1. 

7. **Delete Employees** 

Create a table **Deleted\_Employees(EmployeeId PK, FirstName, LastName, MiddleName, JobTitle, DepartmentId, Salary)** that will hold information about fired (deleted) employees from the **Employees** table. Add a trigger to **Employees** table that inserts the corresponding information about the deleted records in **Deleted\_Employees**. 
