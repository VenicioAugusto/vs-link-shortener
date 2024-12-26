import React, { useState } from "react";
import { shortenUrl } from "../api/urlService";
import { copyToClipboard } from "../utils/clipboardUtils";

function LinkShortener() {
    const [originalUrl, setOriginalUrl] = useState("");
    const [shortenedUrl, setShortenedUrl] = useState("");
    const [isLoading, setIsLoading] = useState(false);

    const handleShorten = async () => {
        setIsLoading(true); // Start loading
        setShortenedUrl(""); // Clear any previous result

        try {
            const result = await shortenUrl(originalUrl);
            setShortenedUrl(result.shortenedUrl);
        } catch (error) {
            alert("Failed to shorten the URL. Please try again.");
        } finally {
            setIsLoading(false); // Stop loading
        }
    };

    const handleCopy = () => {
        copyToClipboard(shortenedUrl);
    };

    return (
        <div style={{ textAlign: "center", marginTop: "50px" }}>
            <h1>URL Shortener</h1>
            <input
                type="text"
                value={originalUrl}
                onChange={(e) => setOriginalUrl(e.target.value)}
                placeholder="Enter a URL to shorten"
                style={{ width: "300px", padding: "10px" }}
            />
            <button
                onClick={handleShorten}
                style={{ marginLeft: "10px", padding: "10px 20px" }}
                disabled={isLoading} // Disable button while loading
            >
                {isLoading ? "Shortening..." : "Shorten URL"}
            </button>

            {shortenedUrl && (
                <div style={{ marginTop: "20px" }}>
                    <p>
                        Shortened URL:{" "}
                        <a href={shortenedUrl} target="_blank" rel="noopener noreferrer">
                            {shortenedUrl}
                        </a>
                    </p>
                    <button onClick={handleCopy} style={{ padding: "10px 20px" }}>
                        Copy to Clipboard
                    </button>
                </div>
            )}
        </div>
    );
}

export default LinkShortener;
