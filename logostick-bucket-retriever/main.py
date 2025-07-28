from fastapi import FastAPI

app = FastAPI()

@app.get("/bucket-retriever/messages/")
async def get_messages():
    return {"message" : "API Call Received"}