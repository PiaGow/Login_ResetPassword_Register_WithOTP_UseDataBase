# Demo-Login-With-OTP-And-QR
# User-Name
Trước khi chạy, vui lòng vào file AppConfig, đổi     
<add name="ModelUserName" connectionString="data source=(local);initial catalog=UserNameDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
thay đổi data source = (local) bằng tên server sql của bạn
ví dụ : tên server sql của bạn là LAPTOPVJPPRO\SQLEXPRESS thì thay đổi như sau:
<add name="ModelUserName" connectionString="data source=LAPTOPVJPPRO\SQLEXPRESS;initial catalog=UserNameDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient" />
