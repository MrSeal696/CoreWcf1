## Структура проекта

* **CoreWcfService** — сервер WCF на ASP.NET Core
* **HttpClientApp** — консольное приложение для тестирования HTTP подключения
* **TcpClientApp** — консольное приложение для тестирования TCP подключения

---

## Запуск сервера

1. Откройте проект **CoreWcfService** в Visual Studio.
2. Запустите проект (F5 или Ctrl+F5).
3. Сервис будет доступен по следующим адресам:

   * HTTP: `http://localhost:5028/http`
   * TCP: `net.tcp://localhost:808/nettcp`

---

## Тестирование клиентов

### HTTP клиент

1. Откройте проект **HttpClientApp**.
2. Запустите консольное приложение.
3. В консоли отобразится:

```
Hello, HTTP Client
```

### TCP клиент

1. Откройте проект **TcpClientApp**.
2. Запустите консольное приложение.
3. В консоли отобразится:

```
Hello, TCP Client
```

---

## Используемые технологии

* .NET 10
* ASP.NET Core
* CoreWCF
* BasicHttpBinding (HTTP)
* NetTcpBinding (TCP)

