��� ����, ����� ���������� �����������, ����� �������� ����� NaukaTestAssignment.sln ����������:

1. � ������������ ������� (solution explorer) �������� ������ EmployeeManagerModel � ������� ���� App.config

2. � ������� <connectionStrings> ����� �������� connectionString:

         connectionString="Data Source=(localdb)\MSSQLLocalDB;
         Initial Catalog=DataBaseName;
         Integrated Security=True"
       providerName="System.Data.SqlClient"/>

3. � ����������� �� �������������� SQL-������� �������� ��������� ������
(�����! ��� "EFDbConnection" ������ ���������� ���������� - ��� ������������ ���������� ��� ��������� � ��������� ��). 
���� ������� ��������� ������������� ���������� ���������� SQL-�������, ���������� �������� �������� DataBaseName � InitialCatalog �� ����� ��������� �������� ���� ������ (��� �� ������, ���� ������ ����� ��� ���).

4. � ������� ���������� �������("Tools->NuGet Package Manager->Package manager console") ������� � ������ "������ �� ���������(default project)" ������ EmployeeManagerModel � ������ ������� update-database

5. ����� ������� update-database ��������� �������� ����� ���� ������ � �������� ������ (�� ��������� DataBaseName).

6. ���������� ����� ��������� � ���������.

P.S. � ������ ������ ��������� ��������, ��������� ���, �� ���� � ���-�� �������� ���������� � ���-�� �� ���������� - � ����� �������� �� ����� ������� �����.
� ���������,
��������.

��������:
Telegram: 	t.me/forintregy
Tel: 		+7 905 213 09 20
E-mail: 	vladimir.vs.w@mail.ru