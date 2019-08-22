# HookLab

[![Azure DevOps builds](https://img.shields.io/azure-devops/build/Naoki-Ikeguchi/0fb24f1c-f96d-4fe9-b02a-2a1fcf3df7cf/1)](https://dev.azure.com/Naoki-Ikeguchi/HookLab/_build?definitionId=1)
[![SUSHI-WARE LICENSE](https://img.shields.io/badge/license-SUSHI--WARE%F0%9F%8D%A3-blue.svg)](https://github.com/MakeNowJust/sushi-ware)

Transfers your notifications on GitLab to Slack.

## Features
- Notify when someone commented to your merge request.

## Installation
1. Create a Slack app.
2. Add the Bot User feature to the app.
3. Deploy this project to Azure Functions.
4. Configure environment variables.
5. Add an integration to the function with the key on GitLab.
6. Done!

## Configuration
```env
GITLAB_SLACK_USER_DICTIONARY="Username=UXXXXXXXX;AnotherUser=UYYYYYYYY;"
SLACK_BOT_TOKEN="xoxb-NNNNNNNNNNN-MMMMMMMMMMMM-ZZZZZZZZZZZZZZZZZZZZZZZZ"
```
