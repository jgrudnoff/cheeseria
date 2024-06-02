FROM node:22

WORKDIR /app

EXPOSE 5180

CMD [ "npm", "run", "dev" ]

COPY package.json /app

RUN npm i --no-audit

COPY . .