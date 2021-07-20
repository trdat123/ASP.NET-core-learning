This repo is created for learning ASP.NET core mvc in web programming course during college. 
Finished at: 18/7/2021 during big pandemic. :(

## **Installation**:

### Step 1. You need to install these pakage:

![image](https://user-images.githubusercontent.com/71772138/126350505-fabaac4b-a938-4239-aacf-32f6b87fb882.png)
![image](https://user-images.githubusercontent.com/71772138/126350631-b95188d1-1101-4235-b6f8-c0eb0b089ed7.png)

### Step 2. Clone this repo by add this line to terminal:

```
$ git clone https://github.com/trdat123/ASP.NET-core-learning.git

```

> Note: If this thing show up, just select `install`.

![image](https://user-images.githubusercontent.com/71772138/126356562-05f65bb4-b0f6-4935-97f3-62a78d0175ce.png)

### Step 3. 

Run the app. If it cause some error, follow the next step.

Go to `Tools > NuGet Pakage Manager > Pakage Manager Console` then run these 2 lines to add data to your local SQL database:

```
Update-Database -Context AuthDbContext
Update-Database -Context Team_1_E_commerceContext
```
If its show error. You need to install some Nugget Pakage. Go to `Tools > NuGet Pakage Manager > Manage Nugget Pakage` and see if you are already have these pakage, if not, go to `Browse` tab and install these pakage manually: (mind the pakage version)

```
 Microsoft.AspNetCore.Identity Version="2.2.0"
 Microsoft.AspNetCore.Identity.EntityFrameworkCore Version="5.0.8"
 Microsoft.AspNetCore.Identity.UI Version="3.1.15"
 Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation Version="3.1.15"
 Microsoft.AspNetCore.Razor"Version="2.2.0"
 Microsoft.AspNetCore.Razor.Runtime Version="2.2.0"
 Microsoft.EntityFrameworkCore Version="5.0.8"
 Microsoft.EntityFrameworkCore.Relational Version="5.0.8"
 Microsoft.EntityFrameworkCore.SqlServer Version="5.0.8"
 Microsoft.EntityFrameworkCore.Tools Version="5.0.8"
```
After install, run 2 `Update-Database` above again. And `Run` the app. 
