import {
    signInWithEmailAndPassword,
    createUserWithEmailAndPassword,
    sendPasswordResetEmail,
    signOut,
    onAuthStateChanged
} from "https://www.gstatic.com/firebasejs/10.8.1/firebase-auth.js";

import { initFirebase } from "./firebase-init.js";

const auth = initFirebase();

window.login = async function(email, password) {
    return await signInWithEmailAndPassword(auth, email, password);
}

window.register = async function(email, password) {
    return await createUserWithEmailAndPassword(auth, email, password);
}

window.resetPassword = async function(email) {
    return await sendPasswordResetEmail(auth, email);
}

window.logout = async function() {
    return await signOut(auth);
}

window.onAuthStateChanged = (dotnetHelper) => {
    auth.onAuthStateChanged(async user => {
        if (!user) {
            dotnetHelper.invokeMethodAsync("AuthStateChanged", null, null);
            return;
        }

        const tokenResult = await user.getIdTokenResult(true);

        dotnetHelper.invokeMethodAsync(
            "AuthStateChanged",
            user.uid,
            tokenResult.claims
        );
    });
};