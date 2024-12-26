const API_BASE_URL = "https://localhost:7117/api/urls";

// Function to send a POST request to shorten a URL
export const shortenUrl = async (originalUrl) => {
    try {
        const response = await fetch(API_BASE_URL, {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify({ originalUrl }),
        });

        if (!response.ok) {
            throw new Error("Failed to shorten the URL");
        }

        return await response.json();
    } catch (error) {
        console.error("Error in shortenUrl:", error);
        throw error;
    }
};
