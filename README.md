# FeedProducts

**Installation steps:**

I have developed this solution in Visual studio 2019 (.net core 3.1).
Clone the repository on local machine. 
Open the solution in Visual studio and build the solution

**Execution steps:**

Open command prompt
Go to local folder directory.
Go to "FeedProducts\bin\Debug\netcoreapp3.1" path inside the local mapped directory.

Execute the exe using following command

FeedProducts.exe feed-products\capterra.yaml

or

FeedProducts.exe feed-products\softwareadvice.json


**Executing test cases:**

Open command prompt
Go to parent folder of the solution file.

Run this command to execute test cases

dotnet test


I have used XUnit test cases in the past as well.


**What would you have done differently if you had had more time**

If had more time, I would have structured the code using some other pattern with more flexibility. Also, I would have checked again the lifetime of the injected dependencies and revise the lifetime accordingly.
