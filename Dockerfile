FROM node:alpine

WORKDIR /app

COPY . /app
RUN cd /app/Server/ && npm install

EXPOSE 8080

CMD ["node", "/app/Server/index.js"]