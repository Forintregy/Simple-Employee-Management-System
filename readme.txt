Для того, чтобы приложение запустилось, после открытия файла NaukaTestAssignment.sln необходимо:

1. В Обозревателе проекта (solution explorer) раскрыть проект EmployeeManagerModel и открыть файл App.config

2. В разделе <connectionStrings> найти параметр connectionString:

         connectionString="Data Source=(localdb)\MSSQLLocalDB;
         Initial Catalog=DataBaseName;
         Integrated Security=True"
       providerName="System.Data.SqlClient"/>

3. В зависимости от установленного SQL-сервера изменить параметры строки
(ВАЖНО! Имя "EFDbConnection" должно оставаться неизменным - оно используется программой для обращения к контексту БД). 
Если текущие параметры соответствуют параметрам имеющегося SQL-сервера, достаточно изменить значение DataBaseName в InitialCatalog на любое свободное название базы данных (или не менять, если такого имени ещё нет).

4. В Консоли диспетчера пакетов("Tools->NuGet Package Manager->Package manager console") выбрать в списке "Проект по умолчанию(default project)" проект EmployeeManagerModel и ввести команду update-database

5. После запуска update-database произойдёт создание новой базы данных с заданным именем (по умолчанию DataBaseName).

6. Приложение можно запускать и проверять.

P.S. Я описал запуск настолько подробно, насколько мог, но если я где-то допустил неточность и что-то не заработало - я готов ответить по любым каналам связи.
С уважением,
Владимир.

Контакты:
Telegram: 	t.me/forintregy
Tel: 		+7 905 213 09 20
E-mail: 	vladimir.vs.w@mail.ru