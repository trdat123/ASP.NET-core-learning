This repo is created for learning ASP.NET core mvc in web programming course during my college.

Finished at: 18/7/2021.

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
If its show error. You need to install some Nugget Pakage. Go to `Tools > NuGet Pakage Manager > Manage Nugget Pakage` and see if you are already have these pakage, if not, go to `Browse` tab and install these pakage manually: (mind the pakage version).

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

------
### Add some data (optional)
#### **Step 1.**
Go to `View > SQL Server Object Explorer` and go to `(localDb)\MSSQLLocalDB > Databases > Team1 Ecommerce` then right-click `dbo.Category > View Code`.
#### **Step 2.**
Select `⬆️ Update > Generate Script`. Then add the following code to the end of the `SQLQuery1.sql` file and click `▶️ Execute`.
```sql
SET IDENTITY_INSERT [dbo].[Category] ON
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Apple Iphone Series')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Samsung')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (3, N'Xiaomi')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (4, N'Oppo')
INSERT INTO [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (5, N'Realme')
SET IDENTITY_INSERT [dbo].[Category] OFF
```
#### **Step 3.**
Repeat step 1 and 2 but for the `dbo.Product` table. The code for insert table:
```sql
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (11, N'Điện thoại OPPO Reno5', N'oppo-reno5-bac.jpg', 8080000, N'128GB', 4, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (14, N'Điện thoại iPhone XR 64GB', N'iphone-xr-do.jpg', 14990000, N'64GB', 1, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (15, N'Điện thoại Realme 8 5G', N'realme-8-5g-xanh.jpg', 7430000, N'128GB', 5, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (18, N'Samsung Galaxy A52', N'samsung-galaxy-a52-den210926682.jpg', 8640000, N'128GB', 2, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (19, N'Điện thoại Xiaomi POCO X3 NFC', N'xiaomi-redmi-note-10-5g-bac211504464.jpg', 5770000, N'128GB', 3, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (20, N'Điện thoại Samsung Galaxy S21', N'samsung-galaxy-s21-trang211728503.jpg', 14990000, N'128GB', 2, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (21, N'Điện thoại iPhone 12 Pro Max', N'iphone-12-pro-max-xam211849265.jpg', 30590000, N'128GB', 1, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (22, N'Điện thoại iPhone 11', N'iphone-11-do212013678.jpg', 19990000, N'128GB', 1, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (23, N'Điện thoại iPhone SE', N'iphone-se-64gb-2020-trang212134299.jpg', 12490000, N'64GB', 1, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (24, N'Điện thoại Xiaomi Redmi Note 10', N'xiaomi-redmi-note-10212505507.jpg', 4820000, N'128GB', 3, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (26, N'Điện thoại OPPO A74', N'oppo-a74-xanh-duong.jpg', 6220000, N'128GB', 4, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (27, N'Điện thoại Samsung Galaxy A20s', N'samsung-galaxy-a20s-den213959686.jpg', 4890000, N'64GB', 2, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (28, N'Điện thoại Samsung Galaxy A12', N'samsung-galaxy-a12-xanh-211951030.jpg', 4290000, N'128GB', 2, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (29, N'Điện thoại iPhone 12 mini', N'iphone-12-mini-xanh-duong212137301.jpg', 18990000, N'64GB', 1, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (30, N'Điện thoại Samsung Galaxy A31', N'samsung-galaxy-a31212403291.jpg', 5340000, N'128GB', 2, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (31, N'Điện thoại Xiaomi Redmi Note 9S', N'xiaomi-redmi-note-9s212633805.jpg', 5190000, N'128GB', 3, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (32, N'Điện thoại Xiaomi Redmi Note 10S', N'xiaomi-redmi-note-10s-xam212742993.jpg', 6490000, N'128GB', 3, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (33, N'Điện thoại Xiaomi Redmi Note 9 ', N'xiaomi-redmi-note-9-xam212903162.jpg', 3490000, N'128GB', 3, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (34, N'Điện thoại OPPO A94', N'oppo-a94-den213126045.jpg', 7150000, N'128GB', 4, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (35, N'Điện thoại OPPO A54', N'oppo-a54-xanh213307561.jpg', 4360000, N'128GB', 4, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (36, N'Điện thoại OPPO A15', N'oppo-a15-den213417833.jpg', 3240000, N'32GB', 4, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (37, N'Điện thoại Realme C25s', N'realme-c25s-xanh213618093.jpg', 4640000, N'128GB', 5, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (38, N'Điện thoại Realme C17', N'realme-c17-xanh213714637.jpg', 4920000, N'128GB', 5, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (39, N'Điện thoại Realme 8 Pro', N'realme-8-pro-den213824914.jpg', 8080000, N'128GB', 5, 10)
INSERT INTO [dbo].[Product] ([Id], [ModelName], [Image], [Price], [ModelType], [CategoryId], [Quantity]) VALUES (40, N'Điện thoại Realme 6 Pro', N'realme-6-pro-mau-do213932510.jpg', 6990000, N'128GB', 5, 10)
SET IDENTITY_INSERT [dbo].[Product] OFF
```
------
> ### *Good Luck!*
