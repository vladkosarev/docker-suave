FROM fsharp/fsharp

WORKDIR /app

ADD . /app

RUN mono paket.exe install

EXPOSE 8083

CMD ["fsharpi", "app.fsx"]
