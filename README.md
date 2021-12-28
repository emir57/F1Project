# F1Project
Asp.Net Core MVC ⚙️<br>
(Data Layer)⚙️<br>
(Business Layer)⚙️<br>
(Presentation Layer)⚙️<br>
Async Programming ⚙️<br>
Dependency Injection ⚙️<br>
using Microsoft Identity ⚙️<br>
using MsSql 📒<br>
Email Service 📧

<hr>
<br>
Tables📋<br>
Users Table <br>
<table>
  <tr>
  <td>Id</td>
  <td>firstName</td>
  <td>lastName</td>
  <td>DateOfBirth</td>
  <td>profilePhoto</td>
  <td>Email</td>
  <td>EmailConfirmed</td>
  <td>PasswordHash</td>
  <td>SecurityStamp</td>
  <td>PhoneNumber</td>
  <td>PhoneNumberConfirmed</td>
  <td>TwoFactorEnabled</td>
  <td>LockoutEndDateUtc</td>
  <td>LockoutEnabled</td>
  <td>AccessFailedCount</td>
  <td>UserName</td>
  <td>profileDescription</td>
  </tr>
</table>
<br>

Role Table <br>
<table>
  <tr>
  <td>Id</td>
  <td>Name</td>
  </tr>
</table>
<br>
UserRoles Table <br>
<table>
  <tr>
  <td>UserId</td>
  <td>RoleId</td>
  </tr>
</table>
<br>

Drivers Table <br>
<table>
  <thead>
    <tr>
      <th>Column Name</th>
      <th>Data Type</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>DriverId</td>
      <td>int</td>
    </tr>
    <tr>
      <td>DriverName</td>
      <td>nvarchar(max)</td>
    </tr>
    <tr>
      <td>DriverSurname</td>
      <td>nvarchar(max)</td>
    </tr>
    <tr>
      <td>DriverNumber</td>
      <td>tinyint</td>
    </tr>
    <tr>
      <td>TeamId</td>
      <td>int</td>
    </tr>
    <tr>
      <td>DateOfBirth</td>
      <td>datetime2(7)</td>
    </tr>
    <tr>
      <td>CountryId</td>
      <td>int</td>
    </tr>
    <tr>
      <td>DriverImageUrl</td>
      <td>nvarchar(120)</td>
    </tr>
  </tbody>
</table>
<br>
Teams Table <br>
<table>
  <thead>
    <tr>
      <th>Column Name</th>
      <th>Data Type</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>TeamId</td>
      <td>int</td>
    </tr>
    <tr>
      <td>Name</td>
      <td>nvarchar(30)</td>
    </tr>
    <tr>
      <td>Founder</td>
      <td>nvarchar(50)</td>
    </tr>
    <tr>
      <td>FoundationYear</td>
      <td>datetime2(7)</td>
    </tr>
    <tr>
      <td>TeamBoss</td>
      <td>nvarchar(30)</td>
    </tr>
    <tr>
      <td>TeamImageUrl</td>
      <td>nvarchar(120)</td>
    </tr>
  </tbody>
</table>
<br>

Posts Table <br>
<table>
  <thead>
    <tr>
      <th>Column Name</th>
      <th>Data Type</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>PostId</td>
      <td>int</td>
    </tr>
    <tr>
      <td>Title</td>
      <td>nvarchar(45)</td>
    </tr>
    <tr>
      <td>ImageTitleUrl</td>
      <td>nvarchar(120)</td>
    </tr>
    <tr>
      <td>BodyText</td>
      <td>nvarchar(max)</td>
    </tr>
    <tr>
      <td>ImageUrl1</td>
      <td>nvarchar(120)</td>
    </tr>
    <tr>
      <td>ImageUrl2</td>
      <td>nvarchar(120)</td>
    </tr>
    <tr>
      <td>SharingDateTime</td>
      <td>datetime2(7)</td>
    </tr>
  </tbody>
</table>
<br>

PostDriver Table <br>
<table>
  <thead>
    <tr>
      <th>Column Name</th>
      <th>Data Type</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>PostId</td>
      <td>int</td>
    </tr>
    <tr>
      <td>DriverId</td>
      <td>int</td>
    </tr>
  </tbody>
</table>
<br>

PostTeam Table <br>
<table>
  <thead>
    <tr>
      <th>Column Name</th>
      <th>Data Type</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>PostId</td>
      <td>int</td>
    </tr>
    <tr>
      <td>TeamId</td>
      <td>int</td>
    </tr>
  </tbody>
</table>
<br>

Countries Table <br>
<table>
  <thead>
    <tr>
      <th>Column Name</th>
      <th>Data Type</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>CountryId</td>
      <td>int</td>
    </tr>
    <tr>
      <td>CountryName</td>
      <td>nvarchar(60)</td>
    </tr>
    <tr>
      <td>CountryImageUrl</td>
      <td>nvarchar(120)</td>
    </tr>
  </tbody>
</table>
<br>
