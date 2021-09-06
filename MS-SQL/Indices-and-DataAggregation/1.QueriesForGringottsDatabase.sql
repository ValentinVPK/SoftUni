SELECT * FROM WizzardDeposits

--01. Records’ Count
SELECT COUNT(*) AS [Count] FROM WizzardDeposits

--02. Longest Magic Wand

SELECT MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits

--03. Longest Magic Wand per Deposit Groups

SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand  FROM WizzardDeposits
	GROUP BY DepositGroup

--04. Smallest Deposit Group per Magic Wand Size 

SELECT TOP(2) DepositGroup FROM WizzardDeposits
	GROUP BY DepositGroup
	ORDER BY AVG(MagicWandSize)

--05. Deposits Sum

SELECT DepositGroup, SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
	GROUP BY DepositGroup

--06. Deposits Sum for Ollivander Family
SELECT DepositGroup, SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
	GROUP BY DepositGroup, MagicWandCreator
	HAVING MagicWandCreator = 'Ollivander family'

--07. Deposits Filter

SELECT DepositGroup, SUM(DepositAmount) AS TotalSum FROM WizzardDeposits
	GROUP BY DepositGroup, MagicWandCreator
	HAVING MagicWandCreator = 'Ollivander family' AND SUM(DepositAmount) < 150000
	ORDER BY TotalSum DESC

--08. Deposit Charge

SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge FROM WizzardDeposits
	GROUP BY DepositGroup, MagicWandCreator
	ORDER BY MagicWandCreator, DepositGroup

--09. Age Groups
SELECT AgeGroup, COUNT(*) FROM
(SELECT *,
	   CASE 
		WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
		WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
		WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
		WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
		WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
		WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
		WHEN Age > 60 THEN '[61+]'
	   END AS AgeGroup
FROM WizzardDeposits) AS k
	GROUP BY k.AgeGroup

--10. First Letter

SELECT LEFT(FirstName, 1) AS FirstLetter FROM WizzardDeposits
	GROUP BY DepositGroup, LEFT(FirstName, 1)
	HAVING DepositGroup = 'Troll Chest'
	ORDER BY FirstLetter

--11. Average Interest

SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) FROM WizzardDeposits
	WHERE DepositStartDate > '1985-01-01'
	GROUP BY DepositGroup, IsDepositExpired
	ORDER BY DepositGroup DESC, IsDepositExpired

--12. Rich Wizard, Poor Wizard
SELECT SUM(k.Difference) AS SumDifference FROM
(SELECT DepositAmount - LEAD(DepositAmount, 1) OVER (ORDER BY Id) AS [Difference]
	FROM WizzardDeposits) AS k

