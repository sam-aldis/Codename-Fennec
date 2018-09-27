#!/usr/bin/env zsh
yaml2json .gi.api_key.yml --save;
export CIRCLE_TOKEN=$(node export.js);
curl --user ${CIRCLE_TOKEN}: \
    --request POST \
    --form revision=a8eee6bf01328de229f0e67c283b6ff977a8e6fa\
    --form config=@config.yml \
    --form notify=false \
        https://circleci.com/api/v1.1/project/github/sam-aldis/Codename-Fennec/tree/master