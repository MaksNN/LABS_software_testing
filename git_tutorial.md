# Инструкция по работе с Git
## Подготовка рабочего места
### git config --global user.name
### git config --global user.email
### git config
### git version
## Инициализация репозитория
### git init
### git add <file_name> | .
## Первый коммит
### git commit -m
## Ветки в Git
### git branch
### git checkout
### git merge
## История коммитов и работа с коммитами
### git log  | --oneline | --stat | 
### git diff
### q (выход из git diff)
## Работа с удаленным репозиторием
### git remote add origin <address>
### git push -u -f origin main
# Домашнее задание №1
## Написать команду, которая автоматически индексирует и коммитит файл
### git commit -a -m <commit_name>
# Домашнее задание №2
## Написать команду, которая позволяет изменить последний коммит
### git commit --amend | --amend -m <new_commit_name>