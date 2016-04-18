FROM fsharp/fsharp

WORKDIR /app

ADD . /app

EXPOSE 8083

CMD ["fsharpi", "app.fsx"]
