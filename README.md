# DISCLAIMER
This plugin is a hack around current steam protocols, and thus can lead to any unforeseen consequences. You use this plugin at your own risk, neither author of this plugin, nor developers of ASF don't take any responsibility for possible outcomes. Also, developer of ASF explicitly said *"I strongly recommend against using it"*. Don't download and don't install this plugin if you are not agree to take all the risks to yourself.


# ASF Chat Hack Plugin
After recent update of chat system in Steam, and proper implementation of those chats support in [ASF](https://github.com/JustArchiNET/ArchiSteamFarm/), some users encountered a strange issue - sometimes, notifications about new chat messages from bots (both answers to commands and notifications about new incoming trades) got "stuck" - even if you have read this message, and chat window does not show unread messages, steam client still have a notification saying "N new chat messages". This plugins aims to help with this issue, if you never had this issue - this plugin is useless for you. Otherwise, continue reading.

## How does it works?
This plugin completely disables steam chat support in ASF, so you only get those messages in your official Steam client. For me it solved the issue with "stuck" notification, but it may be different for you, I don't guarantee this plugin will work, check it yourself. This implies some limitations, that should be obvious for you, but I still add a list here:
- because chat is disabled, ASF can't receive any messages for this account. If you have only one account this leaves you only one option to send commands - via IPC. If you have more than one bot - you can still send commands to other bots, where this "hack" is not active.
- ASF can't clear notifications about new chat messages, so `MarkReceivedMessagesAsRead` option in `BotBehaviour` [ASF config property](https://github.com/JustArchiNET/ArchiSteamFarm/wiki/Configuration) will not work, and you will receive all notifications about new messages in your Steam Client.
- as a result, ASF can't log messages, so if you use custom nlog configuration to log messages on this account, this plugin is not suitable for you.

This plugin will only work for accounts with `OnlineStatus` [property](https://github.com/JustArchiNET/ArchiSteamFarm/wiki/Configuration) set to `Offline` (`0`). This makes sense, because offline accounts don't respond to messages anyway, and you only need this plugin for main account, where `Offline` mode is useful. If you don't use `Offline` mode this plugin does not suits you.

Works only with ASF 4.0+ (check release notes to find out actual required version of ASF).

## How to use:
- download .zip file from [latest release](https://github.com/Ryzhehvost/ASF-ChatHack/releases/latest), in most cases you need `ASF-ChatHack.zip`, but if you use ASF-generic-netf.zip (you really need a strong reason to do that) download `ASF-ChatHack.zip`. Make sure that release you choose supports your ASF version.
- unpack downloaded .zip file to `plugins` folder inside your ASF folder.
- (re)start ASF, you should get a message indicating that plugin loaded successfully. 


# ОТКАЗ ОТ ОТВЕТСВЕННОСТИ
Этот плагин представляет из себя "хак" протоколов Steam, и поэтому может привести к любым непредвиденным последствиям. Вы используете этот плагин на свой риск и страх, и ни автор этого плагина, ни разработчики ASF не несут никакой отвественности за возможные последствия. Более того, разработчик ASF недвусмысленно заявил: *"I strongly recommend against using it"* (" настоятельно не рекомендую его использовать"). Не скачивайте и не устанавливайте этот плагин если вы не согласны взять на себя ответственность за связанные риски.


# Плагин "Chat Hack" для ASF 
После недавнего обновления системы чатов в, и соответствующей реализации поддержки этих чатов в [ASF](https://github.com/JustArchiNET/ArchiSteamFarm/), некоторые пользователи столкнулись со следующей проблемой: уведомления о новых сообщениях от ботов в чате, как при ответе на команды, так и при получении предложений обмена, "зависали - даже после того, как вы просмотрели сообщение, и окно чата больше не показывает непрочитанных сообщений, в клиенте Steam остаётся гореть уведомление "N новых сообщений". Цель этого плагина - попытаться решить эту проблему, если вы с такой проблемой не сталкивались - этот плагин для вас совершенно бесполезен. Если же сталкивались - продолжайте читать.

## Как это работает?
Этот плагин полностью отключает поддержку чата Steam в ASF, так что вы будете получать все сообщения только в официальном клиенте Steam. Лично для меня - это решило проблему с "зависшими" уведомлениями, но для вас это может оказаться не так, я не могу гарантировать что этот плагин вам поможет, проверяйте сами. Это подразумевает некоторые ограничения, которые должны быть очевидны, но я всё же их приведу:
- поскольку чат отключен, ASF не сможет получать никаких сообщений для этого аккаунта. Если у вас только один аккаунт - вам остаётся только один способ отправки команды - через IPC. Если у вас больше одного бота - вы всё ещё можете отправлять команды через этих ботов, для которых чат не отключен.
- ASF не сможет очищать уведомления о новых сообщениях, поэтому опция `MarkReceivedMessagesAsRead` в [параметре конфигурации ASF](https://github.com/JustArchiNET/ArchiSteamFarm/wiki/Configuration-ru-RU) `BotBehaviour` не будет работать, и вы будете получать уведомления в клиенте Steam обо всех новых сообщениях (ну, хотя бы они не зависнут, да?).
- как следствие, ASF не может писать в лог полученные сообщения, поэтому если вы настроили сохранение с помощью пользовательской конфигурации nlog, этот плагин вам не подходит.

Этот плагин будет работать только на ботах, для которых [параметр](https://github.com/JustArchiNET/ArchiSteamFarm/wiki/Configuration) `OnlineStatus` установлен равным `Offline` (`0`). Это логично, поскольку боты в режиме `Offline` всё равно не могут реагировать на сообщения, а этот плагин полезен только для основного аккаунта, где режим `Offline` будет полезен. Если вы не пользуетесь режимом `Offline` - этот плагин не будет работать, и потому бесполезен для вас.

Работает только в ASF 4.0+ (проверьте информацию о релизе чтобы узнать реально необходимую версию ASF)

## Установка:
- скачайте файл .zip из [последнего релиза](https://github.com/Ryzhehvost/ASF-ChatHack/releases/latest), в большинстве случаев вам нужен файл `ASF-ChatHack.zip`, не если вы по какой-то причине пользуетесь ASF-generic-netf.zip (а для этого нужны веские причины) - скачайте `ASF-ChatHack-netf.zip`. Убедитесь что выбранный релиз поддерживает вашу версию ASF.
- распакуйте скачанный файл .zip в папку `plugins` внутри вашей папки с ASF.
- (пере)запустите ASF, вы должны получить сообщение что плагин успешно загружен. 

![downloads](https://img.shields.io/github/downloads/Ryzhehvost/ASF-ChatHack/total.svg?style=social)
